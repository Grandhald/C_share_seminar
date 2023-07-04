//Задача 3: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9
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

int[] ArrayDict(int[,] array)
{
    int [] Dict = new int[10];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
          Dict[array[j,i]]++;
        }
    }
    return Dict;
}
int[] ArrayDictSecond(int [,] array)
{
    int [] Dict = new int[10];
    foreach (int elem in array)
    {
        Dict[elem]++;
    }
    return Dict;
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

        Console.WriteLine($"{i} - {array[i]}");
    }
    
}



int count_rows = Inputed("Введите количество строк: ");
int count_columns = Inputed("Введите количество столбцов: ");
int[,] matrix = GenerateInsertedArray(count_rows, count_columns, 0, 10);
PrintInsertedArray(matrix);
Console.WriteLine();
PrintArray(ArrayDict(matrix));