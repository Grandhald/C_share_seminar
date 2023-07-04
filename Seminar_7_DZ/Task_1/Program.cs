// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

double[,] inserted_array = GenerateInsertedArray(count_rows, count_columns, min_line_num, max_line_num);
PrintInsertedArray(inserted_array);