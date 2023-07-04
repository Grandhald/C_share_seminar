// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 0 -> 1

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

double[,] GenerateInsertedArray (int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.Next(min,max)+ rnd.NextDouble(), 3);
        }
    }
    return matrix;
}

string SearchElemArrayByPossition(int numRow, int numCol, double [,] array)
{
    int count_rows = array.GetLength(0);
    int count_columns = array.GetLength(1);
    if (0>numRow || numRow>=count_rows || 0>numCol || numCol>=count_columns)
    {
        return "такого числа в массиве нет";
    }
    return $"{array[numRow, numCol]}";
}

void PrintInsertedArray(double[,] array)
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
int row = Inputed("Введите номер строки: ");
int columns = Inputed("Введите номер столбцы: ");

double[,] inserted_array = GenerateInsertedArray(count_rows, count_columns, min_line_num, max_line_num);
Console.WriteLine();
PrintInsertedArray(inserted_array);
Console.WriteLine();
Console.WriteLine(SearchElemArrayByPossition(row, columns,inserted_array));
