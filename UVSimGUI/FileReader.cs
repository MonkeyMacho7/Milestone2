using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSimGUI
{
    public class FileReader
    {
        public List<string> list;

        public FileReader(string filePath)
        {
            list = new List<string>();
            try
            {
                int recordRead = 0;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string instruction = line[1..];
                        list.Add(instruction);
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
        public class FileConverter
        {
            public List<string> ConvertToSixDigitFormat(string filePath)
            {
                List<string> convertedInstructions = new List<string>();

                // Read each line of the file
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string sign = line.Substring(0, 1); // Extract the sign (+ or -)
                        string operationCode = line.Substring(1, 2).PadLeft(3, '0'); // Convert operation code to 3 digits

                        string operand = "000"; // Default operand
                        if (line.Length == 5) // Check if there is an operand
                        {
                            operand = line.Substring(3, 2).PadLeft(3, '0'); // Convert operand to 3 digits
                        }

                        convertedInstructions.Add(sign + operationCode + operand);
                    }
                }

                return convertedInstructions;
            }
        }
        public List<string> GetInstructions()
        {
            return list;
        }

        public int GetInputCount()
        {
            int count = 0;
            foreach (string i in list)
            {
                var op = Convert.ToInt32(i.Substring(0,3));
                //ML operation 10 is input
                if (op == 010) count++;
            }
            return count;
        }
    }
}
