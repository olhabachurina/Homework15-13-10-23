using Homework15__13_10_23;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayManager

{
    public int[] ReadArrayFromUser()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter array element #{i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public int[] ReadArrayFromFile()
    {
        Console.Write("Enter a file name to load the array: ");
        string filename = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(filename);
            int[] array = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                array[i] = int.Parse(lines[i]);
            }

            return array;
        }
        catch (IOException e)
        {
            Console.WriteLine($"ОError reading from file: {e.Message}");
            return new int[0];
        }
    }

    public void SaveArrayToFile(string filename, int[] array)
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
            Console.WriteLine($"Error writing to file: {e.Message}");
        }
    }

    public void PrintArray(int[] array)
    {
        Console.WriteLine("Array:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }
}

