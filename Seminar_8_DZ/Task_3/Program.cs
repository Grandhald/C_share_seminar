//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

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

int [,] MatrixProduct(int [,] matrix_A, int [,] matrix_B)
{
    int [,] matrixProd = new int[matrix_A.GetLength(0),matrix_B.GetLength(1)];
    int elem = 0;
    for (int l = 0; l < matrix_A.GetLength(0); l++)
    {
        for (int i = 0; i < matrix_B.GetLength(1); i++)
        {
            elem = 0;
            for (int j = 0; j < matrix_B.GetLength(0); j++)
            {
                elem += matrix_A[l,j]*matrix_B[j,i];
            }
            matrixProd[l,i] = elem;
        }
    }
    return matrixProd;
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
    Console.WriteLine();
}


int rows_coloms_matrix = Inputed("Введите количество столбцов и строк первой и второй матрицы: ");
int count_row = Inputed("Введите количество строк первой матрицы: ");
int count_columns = Inputed("Введите количество столбцов второй матрицы: ");
int min_line_num = Inputed("Введите нижнюю границу диапзона рандомных чисел: ");
int max_line_num = Inputed("Введите верхнюю границу диапзона рандомных чисел: ");

int [,] matrixFirst = GenerateInsertedArray(count_row, rows_coloms_matrix, min_line_num, max_line_num);
int [,] matrixSecond = GenerateInsertedArray(rows_coloms_matrix, count_columns, min_line_num, max_line_num);
int [,] matrixProduct = MatrixProduct(matrixFirst, matrixSecond);

Console.WriteLine("Первая матрица: ");
PrintInsertedArray(matrixFirst);
Console.WriteLine("Вторая матрица: ");
PrintInsertedArray(matrixSecond);
Console.WriteLine("Произведение матриц: ");
PrintInsertedArray(matrixProduct);




