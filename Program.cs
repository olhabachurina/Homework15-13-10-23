// See https://aka.ms/new-console-template for more informatio
using Homework15__13_10_23;

Console.WriteLine("Exercise 1");
Console.WriteLine("enter the path to the file:");
string filePath = Console.ReadLine();
try
{
    if (File.Exists(filePath))
    {
        string fileContent = File.ReadAllText(filePath);
    Console.WriteLine($"Contents of the file {filePath}:\n{fileContent}");
    }
    else
{
    Console.WriteLine($"The file {filePath} does not exist.");
}
}
catch (Exception ex)
{
    Console.WriteLine($"error: {ex.Message}");
}
Console.WriteLine("Exercise 2,3");

int[] array;

Console.Write("Select action (1 - Enter array, 2 - Load array from file): ");
int choice = int.Parse(Console.ReadLine());

ArrayManager arrayManager = new ArrayManager();

switch (choice)
{
    case 1:
        array = arrayManager.ReadArrayFromUser();
        break;

    case 2:
        array = arrayManager.ReadArrayFromFile();
        break;

    default:
        Console.WriteLine("Error");
        return;
}

Console.Write("Enter the file name to save/load the array: ");
string filename = Console.ReadLine();

if (choice == 1)
{
    arrayManager.SaveArrayToFile(filename, array);
    Console.WriteLine($"The array is saved to a file {filename}");
}
else
{
    Console.WriteLine($"Array loaded from file {filename}");
    arrayManager.PrintArray(array);
}


Console.WriteLine("Exercise 4");
int[] numbers = ArrayGenerator.GenerateRandomNumbers(10000);

// Разделение на четные и нечетные
int[] evenNumbers = FileOperations.GetEvenNumbers(numbers);
int[] oddNumbers = FileOperations.GetOddNumbers(numbers);

// Сохранение в файлы
FileOperations.SaveArrayToFile("even_numbers.txt", evenNumbers);
FileOperations.SaveArrayToFile("odd_numbers.txt", oddNumbers);

// Вывод статистики
Console.WriteLine($"Total numbers: {numbers.Length}");
Console.WriteLine($"Even numbers: {evenNumbers.Length}");
Console.WriteLine($"Odd numbers: {oddNumbers.Length}");