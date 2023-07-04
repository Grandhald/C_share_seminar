//Задача 4: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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

int [] SearchMinArrayinserted(int [,] array)
{
    int [] possition = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[possition[0],possition[1]] > array[i,j])
            {
                possition[0] = i;
                possition[1] = j;
            }
        }
    }
    return possition;
}

int [,] ArrayDelPossition(int [,] array, int [] possit)
{
    int [,] result = new int[array.GetLength(0)-1,array.GetLength(1)-1];
    int indexRow = 0;
    int indexColums = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i==possit[0])
        {
            continue;
        }
        indexColums = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j==possit[1])
            {
                continue;
            }
            result[indexRow,indexColums] = array[i,j];
            indexColums++;
        }
        indexRow++;
    }
    return result;
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

int [,] matrix = GenerateInsertedArray(5, 4, 0, 10);
int [] possMinArrayinsert = SearchMinArrayinserted(matrix);
int [,] matrixDelposs = ArrayDelPossition(matrix,possMinArrayinsert);
PrintInsertedArray(matrix);
Console.WriteLine();
PrintInsertedArray(matrixDelposs);

