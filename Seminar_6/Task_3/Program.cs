//Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] GenerateArray(int len, int min, int max)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] arrayNew = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {  
        arrayNew[i] = array[i];
    }

    return arrayNew;
}

int[] array = GenerateArray(8, 5, 10);
PrintArray(array);
Console.WriteLine();
int[] arrayCopy = CopyArray(array);
PrintArray(arrayCopy);
Console.WriteLine();
int [] arrayDup = array;
PrintArray(arrayDup);
Console.WriteLine();

array[1] = 2000;

PrintArray(arrayDup);
Console.WriteLine();