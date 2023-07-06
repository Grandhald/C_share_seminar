// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] SumRowArrayInserted(int[,] array)
{
    int[] arraySumElemRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arraySumElemRow[i] = sum;
    }
    return arraySumElemRow;
}

int  SearchRowWithMaxSumArrayInserted(int[] sumElemRow)
{
    int  rowMinSumElem = 0;
    for (int i = 0; i < sumElemRow.Length; i++)
    {
        if (sumElemRow[rowMinSumElem] > sumElemRow[i])
        {
            rowMinSumElem = i;
        }
    }
  
    return rowMinSumElem+1;
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+"\t");
    }
    Console.WriteLine();  
}

int count_rows = Inputed("Введите количество строк: ");
int count_columns = Inputed("Введите количество столбцов: ");
int min_line_num = Inputed("Введите нижнюю границу диапзона рандомных чисел: ");
int max_line_num = Inputed("Введите верхнюю границу диапзона рандомных чисел: ");

int[,] massif = GenerateInsertedArray(count_rows, count_columns, min_line_num, max_line_num);
int[] sumElemRowMassif = SumRowArrayInserted(massif);
int maxSumRowMassif = SearchRowWithMaxSumArrayInserted(sumElemRowMassif);

PrintInsertedArray(massif);
Console.WriteLine();
Console.WriteLine("Сумма элементов каждой из строк");
PrintArray(sumElemRowMassif);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов -->> {maxSumRowMassif}");
