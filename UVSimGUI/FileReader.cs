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
        public List<string> GetInstructions()
        {
            return list;
        }

        public int GetInputCount()
        {
            int count = 0;
            foreach (string i in list)
            {
                var op = Convert.ToInt32(i.Substring(0,2));
                //ML operation 10 is input
                if (op == 10) count++;
            }
            return count;
        }
    }
}
