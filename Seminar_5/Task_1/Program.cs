// Задача 1: Напишите программу замены 
//элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

int [] ReverseArray(int[] input)
{
    for(int index = 0; index < input.Length; index++)
    {
        input [index] = input [index] * -1;
    }
    return input;
}

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

int[] newArray = GenerateArray(10, -10, 10);
PrintArray(newArray);
Console.WriteLine();
int[] reverse = ReverseArray(newArray);
PrintArray(reverse);