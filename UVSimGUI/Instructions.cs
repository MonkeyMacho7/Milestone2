using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSimGUI
{
    public class Instructions
    {
        public static string[] instructions = new string[250];
        public static int[] inputs = new int[250];
        public static int pointer = 0;
        public static int[] memory = new int[250];
        public static int accumulator = 0;

        public Instructions() { }
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
        public void Reset()
        {
            accumulator = 0;
            pointer = 0;
            Array.Clear(memory, 0, memory.Length);
            Array.Clear(inputs, 0, inputs.Length);
        }

        public void LoadInsructions(List<string> list, string txtInput)
        {
            if (list.Count > 250)
            {
                throw new Exception("Too many instructions. Maximum is 250.");
            }

            // Load instructions into the instructions array
            for (int i = 0; i < list.Count; i++)
            {
                // Ensure each instruction is exactly 6 digits long
                if (list[i].Length != 6)
                {
                    throw new FormatException("Invalid instruction length. Each instruction must be 6 digits.");
                }
                instructions[i] = list[i];
            }

            // Reset the inputs array before loading new inputs
            Array.Clear(inputs, 0, inputs.Length);

            // Load inputs
            var arrInputs = txtInput.Split(',');
            if (arrInputs.Length > inputs.Length)
            {
                throw new Exception("Too many inputs. Maximum is 250.");
            }

            for (int i = 0; i < arrInputs.Length; i++)
            {
                inputs[i] = Convert.ToInt32(arrInputs[i]);
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
                    var operation = (int)Convert.ToInt32(instructions[current].Substring(0, 3));
                    //get the operand
                    var operand = (int)Convert.ToInt32(instructions[current].Substring(3, 3));

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
                case 010:
                    int value = inputs[pointer++];
                    status += $"Getting a value to store in memory: {value}{Environment.NewLine}";
                    Console.Write($"Getting a value to store in memory: {value}");
                    memory[operand] = value; // Storing the user input in the specified memory location
                    break;

                case 011:
                    status += $"Value at memory location {operand}: {memory[operand]}{Environment.NewLine}";
                    Console.WriteLine($"Value at memory location {operand}: {memory[operand]}");
                    break;

                case 020:
                    accumulator = memory[operand];
                    break;

                case 021:
                    memory[operand] = accumulator;
                    break;

                case 030:
                    accumulator += memory[operand];
                    break;

                case 031:
                    accumulator -= memory[operand];
                    break;

                case 032:
                    if (memory[operand] == 0)
                    {
                        status += $"Divide by zero error.{Environment.NewLine}";
                        Console.WriteLine("Divide by zero error.");
                        next = -1;
                        return status;
                    }
                    else
                    {
                        accumulator /= memory[operand];
                    }
                    break;

                case 033: 
                    accumulator *= memory[operand];
                    break;

                case 040:
                    status += $"Branching to line {operand}.{Environment.NewLine}";
                    Console.WriteLine($"Branching to line {operand}.");
                    next = operand;
                    return status;

                case 041:
                    if (accumulator < 0)
                    {
                        status += $"Branching to instruction {operand} due to negative accumulator.{Environment.NewLine}";
                        Console.WriteLine($"Branching to instruction {operand} due to negative accumulator.");
                        next = operand;
                        return status;
                    }
                    break;

                case 042:
                    if (accumulator == 0)
                    {
                        status += $"Branching to instruction {operand} due to zero accumulator.{Environment.NewLine}";
                        Console.WriteLine($"Branching to instruction {operand} due to zero accumulator.");
                        next = operand;
                        return status;
                    }
                    break;

                case 043:
                    status += $"Halt operation{Environment.NewLine}";
                    Console.WriteLine("Halt operation");
                    next = 0;
                    return status;
            }

            next = current + 1;
            return status;
        }
    }
}
