using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15__13_10_23
{
    
    
        public class FileOperations
        {
            public static int[] GetEvenNumbers(int[] numbers)
            {
                return Array.FindAll(numbers, x => x % 2 == 0);
            }

            public static int[] GetOddNumbers(int[] numbers)
            {
                return Array.FindAll(numbers, x => x % 2 != 0);
            }

            public static void SaveArrayToFile(string filename, int[] array)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        foreach (int element in array)
                        {
                            writer.WriteLine(element);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error writing to file {filename}: {e.Message}");
                }
            }
        }
    }


