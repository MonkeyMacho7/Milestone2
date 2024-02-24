using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSimGUI
{
    public class Instructions
    {
        public static string[] instructions = new string[100];
        public static int[] inputs = new int[100];
        public static int pointer = 0;
        public static int[] memory = new int[100];
        public static int accumulator = 0;

        public Instructions(List<string> list, string txtInput)
        {
            var n = 0;
            foreach (var i in list)
            {
                instructions[n] = i;
                n++;
            }
            n = 0;
            var arrInputs = txtInput.Split(',');
            while (n < arrInputs.Length)
            {
                inputs[n] = Convert.ToInt32(arrInputs[n]);
                n++;
            }
        }

        public string Process()
        {
            string status = string.Empty;
            try
            {
                var current = (int)0;
                var next = (int)0;
                foreach (var i in instructions)
                {
                    //get the operation
                    var operation = (int)Convert.ToInt32(instructions[current].Substring(0, 2));
                    //get the operand
                    var operand = (int)Convert.ToInt32(instructions[current].Substring(2, 2));

                    //call the BasicML processor
                    status += BasicML(current, operation, operand, out next);
                    if (next <= 0)
                        break;
                    current = next;
                }
            }
            catch (Exception ex) { }
            return status;
        }
        public string BasicML(int current, int operation, int operand, out int next)
        {
            var status = string.Empty;

            if (operand < 0 || operand >= memory.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(operand), "Memory location is out of range.");
            }
            switch (operation)
            {
                case 10:
                    int value = inputs[pointer++];
                    status += $"Getting a value to store in memory: {value}";
                    Console.Write($"Getting a value to store in memory: {value}");
                    memory[operand] = value; // Storing the user input in the specified memory location
                    break;

                case 11:
                    status += $"Value at memory location {operand}: {memory[operand]}";
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
                        status += "Divide by zero error.";
                        Console.WriteLine("Divide by zero error.");
                        next = -1;
                        return status;
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
                    status += $"Branching to line {operand}.";
                    Console.WriteLine($"Branching to line {operand}.");
                    next = operand;
                    return status;

                case 41:
                    if (accumulator < 0)
                    {
                        Console.WriteLine($"Branching to instruction {operand} due to negative accumulator.");
                        next = operand;
                        return status;
                    }
                    break;

                case 42:
                    if (accumulator == 0)
                    {
                        status += $"Branching to instruction {operand} due to zero accumulator.";
                        Console.WriteLine($"Branching to instruction {operand} due to zero accumulator.");
                        next = operand;
                        return status;
                    }
                    break;

                case 43:
                    status += "Halt operation";
                    Console.WriteLine("Halt operation");
                    next = 0;
                    return status;
            }

            next = current + 1;
            return status;
        }
    }
}
