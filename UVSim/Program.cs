using System;
using System.IO;

class Program
{
    public static string[] instructions = new string[100];
    public static int[] memory = new int[100];
    public static int accumulator = 0;
    static void Main(string[] args)
    {
        Console.WriteLine($"UVSim v1.0");
        string filePath = string.Empty;

        if (args.Length > 0)
        {
            filePath = args[0];
        }
        else
        {
            Console.WriteLine("Enter the path to the file:");
            filePath = Console.ReadLine();
        }

        if (File.Exists(filePath))
        {
            ReadFile(filePath);
            ProcessInstructions();
        }
        else
        {
            Console.WriteLine("File not found. Please provide a valid file path.");
        }
    }

    static void ReadFile(string filePath)
    {
        try
        {
            int recordRead = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string instruction = line[1..];
                    instructions[recordRead] = instruction;
                    recordRead++;
                }
            }
            Console.WriteLine($"{recordRead} instructions read from file");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void ProcessInstructions()
    {
        try
        {
            var current = 0;
            var next = 0;
            foreach (var i in instructions)
            {
                //get the operation
                var operation = Convert.ToInt32(instructions[current].Substring(0, 2));
                //get the operand
                var operand = Convert.ToInt32(instructions[current].Substring(2, 2));

                //call the BasicML processor
                next = BasicML(current, operation, operand);
                if (next <= 0)
                    break;
                current = next;
            }
        }
        catch (Exception ex) { }
        return;
    }

    static int BasicML(int current, int operation, int operand)
    {
        switch (operation)
        {
            case 10:
                Console.Write("Enter a value to store in memory: ");
                int value = Convert.ToInt32(Console.ReadLine());
                memory[operand] = value; // Storing the user input in the specified memory location
                break;

            case 11:
                Console.WriteLine($"Value at memory location {operand}: {memory[operand]}");
                break;

            case 20:
                accumulator = memory[operand];
                break;

            case 21:
                memory[operand] = accumulator;
                break;

            case 30:
                accumulator += memory[operand];
                break;

            case 31:
                accumulator -= memory[operand];
                break;

            case 32:
                if (memory[operand] == 0)
                {
                    Console.WriteLine("Divide by zero error.");
                    return -1;
                }
                else
                {
                    accumulator /= memory[operand];
                }
                break;

            case 33:
                accumulator *= memory[operand];
                break;

            case 40:
                Console.WriteLine($"Branching to line {operand}.");
                return operand;

            case 41:
                if (accumulator < 0)
                {
                    Console.WriteLine($"Branching to instruction {operand} due to negative accumulator.");
                    return operand;
                }
                break;

            case 42:
                if (accumulator == 0)
                {
                    Console.WriteLine($"Branching to instruction {operand} due to zero accumulator.");
                    return operand;
                }
                break;

            case 43:
                Console.WriteLine("Halt operation");
                return 0;
        }

        return current+1;
    }
}
