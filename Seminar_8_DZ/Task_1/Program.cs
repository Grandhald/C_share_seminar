// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int[,] GenerateInsertedArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

int[,] SortRowInsertedArray(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = array.GetLength(1)-1; j>0 ; j--)
            {
                if (array[i,j]>array[i,j-1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j-1];
                    array[i,j-1] = temp;
                }
            }
        }

    }
    return array;
}

void PrintInsertedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

int count_rows = Inputed("Введите количество строк: ");
int count_columns = Inputed("Введите количество столбцов: ");
int min_line_num = Inputed("Введите нижнюю границу диапзона рандомных чисел: ");
int max_line_num = Inputed("Введите верхнюю границу диапзона рандомных чисел: ");

int[,] massif = GenerateInsertedArray(count_rows, count_columns, min_line_num, max_line_num);
PrintInsertedArray(massif);
Console.WriteLine();
massif = SortRowInsertedArray(massif);
PrintInsertedArray(massif); 