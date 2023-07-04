// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

double [,] ArrayReserveFirstAndFinStr(double [,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;

    }
    return array;
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
double [,] matrix = GenerateInsertedArray(count_rows, count_columns, 0, 10);
PrintInsertedArray(matrix);
Console.WriteLine();
PrintInsertedArray(ArrayReserveFirstAndFinStr(matrix));
