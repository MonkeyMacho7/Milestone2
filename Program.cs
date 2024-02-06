using System;
using System.IO;

class Program
{
    public static int[] memory = new int[100];

    public static int accumulator = 0;
    static void Main(string[] args)
    {
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
            ProcessFile(filePath);
        }
        else
        {
            Console.WriteLine("File not found. Please provide a valid file path.");
        }
    }

    static void ProcessFile(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int instruction = Convert.ToInt32(line.Substring(0,3));
                    int operand = Convert.ToInt32(line.Substring(3,2));
                    switch(instruction)
                    {
                        case 10: 
                            Console.WriteLine("Read");
                            Console.WriteLine("Enter a value to store in memory:");
                            int value = Convert.ToInt32(Console.ReadLine());
                            memory[operand] = value; // Storing the user input in the specified memory location
                            break;
                        case 11: 
                            Console.WriteLine("Write operation");
                            Console.WriteLine($"Value at memory location {operand}: {memory[operand]}");
                            break;

                        case 20: 
                            Console.WriteLine("Load operation");
                            accumulator = memory[operand];
                            Console.WriteLine($"Loaded {memory[operand]} from memory location {operand} into the accumulator.");
                            break;

                        case 21: 
                            Console.WriteLine("Store operation");
                            memory[operand] = accumulator;
                            Console.WriteLine($"Stored {accumulator} from the accumulator into memory location {operand}.");
                            break;

                        case 30: 
                            Console.WriteLine("Add operation");
                            break;

                        case 31: 
                            Console.WriteLine("Subtract operation");
                            break;

                        case 32: 
                            Console.WriteLine("Divide operation");
                            break;

                        case 33: 
                            Console.WriteLine("Multiply operation");
                            break;

                        case 40: 
                            Console.WriteLine("Branch operation");
                            break;

                        case 41: 
                            Console.WriteLine("Branch if negative operation");
                            break;

                        case 42: 
                            Console.WriteLine("Branch if zero operation");
                            break;

                        case 43: 
                            Console.WriteLine("Halt operation");
                            return; 

                    }
                    // Process each line as needed
                    Console.WriteLine($"Processing line: {line}");
                    // Add your logic here to process the line

                }
            }
            Console.WriteLine("File processing completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
