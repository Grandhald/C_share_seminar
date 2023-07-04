 // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int [,] GenerateInsertedArray (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min,max);
        }
    }
    return matrix;
}

string AverageElemsColumsArray(int [,] array)
{
    
    string avg = ""; 
    double countRow = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        double average = Math.Round(sum/countRow, 3);
        avg += " " + $"{average};";
    }
    avg = avg.Substring(0,avg.Length-1);
    avg += ".";
    return avg;
}

void PrintInsertedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
    
}

int count_rows = Inputed("Введите количество строк: ");
int count_columns = Inputed("Введите количество столбцов: ");
int min_line_num = Inputed("Введите нижнюю границу диапзона рандомных чисел: ");
int max_line_num = Inputed("Введите верхнюю границу диапзона рандомных чисел: ");

int [,] inserted_array = GenerateInsertedArray(count_rows, count_columns, min_line_num, max_line_num);
Console.WriteLine();
PrintInsertedArray(inserted_array);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца:{AverageElemsColumsArray(inserted_array)}");