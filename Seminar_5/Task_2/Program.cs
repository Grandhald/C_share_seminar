//Задайте массив. Напишите программу, которая 
//определяет, присутствует ли заданное число
// в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int [] GenerateArray(int len, int min, int max)
{   
    int [] massif = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        massif[i] = rnd.Next(min,max+1);
    }
    return massif;
}

void ChekNumberInArray(int number, int [] array)
{   string result = $"Число {number} отсутствует в заданном массиве"; 
    foreach (int item in array)
    {
        if (item == number)
        {
           result = $"Число {number} присуствует в заданном массиве";
           break;
        }   
    }
     Console.WriteLine(result);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item+"\t");
    }
    Console.WriteLine();
}

int [] array = GenerateArray(10, 0, 9);
PrintArray(array);
ChekNumberInArray(4, array);