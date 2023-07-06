// Задача 4: * Напишите программу, которая заполнит спирально ДВУМЕРНЫЙ массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

string TranslateNumberinString(int number)
{
    if (number < 10)
    {
        return $"0{number}";
    }
    return $"{number}";
}

string[,] ArrayWitchCountColumnsExatlyOne(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, 0] = TranslateNumberinString(i + 1);
    }
    return matrix;
}

string[,] CreatingASpirallyFilledArray(int rows, int columns)
{
    string[,] matrix = new string[rows, columns];

    if (columns == 1) return ArrayWitchCountColumnsExatlyOne(matrix);

    int i = 0; int j = 0;
    int elementValue = 1;
    int moveRightOrLeft = 1;
    int lenRow = columns; int lenColumns = rows;
    int countTurns = rows * 2 - 1;

    if (rows > columns) countTurns = rows * 2 + 1;
   
    for (int rowORCol = 0; rowORCol < countTurns; rowORCol++)
    {
        if (rowORCol % 2 == 0)
        {
            for (int k = 0; k < lenRow; k++)
            {
                matrix[i, j] = TranslateNumberinString(elementValue);
                elementValue++;
                j += moveRightOrLeft;
            }
            j -= moveRightOrLeft; i += moveRightOrLeft;
            lenColumns--;
        }
        else
        {
            for (int l = 0; l < lenColumns; l++)
            {
                matrix[i, j] = TranslateNumberinString(elementValue);
                elementValue++;
                i += moveRightOrLeft;
            }
            i -= moveRightOrLeft;
            if (moveRightOrLeft == 1) moveRightOrLeft = -1; else moveRightOrLeft = 1;
            j += moveRightOrLeft;
             lenRow--;
        }
    }
    return matrix;
}

void PrintInsertedArray(string[,] array)
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

int count_rows = Inputed("Введите количество строк: ");
int count_columns = Inputed("Введите количество столбцов: ");

string[,] matrix = CreatingASpirallyFilledArray(count_rows, count_columns);
PrintInsertedArray(matrix);