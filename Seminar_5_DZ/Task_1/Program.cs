// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

int [] CreateRandomArray(int len, int min = 100, int max = 1000)
{
    int [] numbers = new int [len];
    Random rdn = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rdn.Next(min, max);
    }   
    return numbers;
}

int CountEvenNumbers (int [] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

string PrintArray (int [] array)
{
    string massifPrint = "[";
    foreach (int item in array)
    {
        massifPrint += $"{item}, ";
    }
    return massifPrint.Substring(0, massifPrint.Length-2)+"]";
}

int Length = Inputed("Введите длину массива: ");
int [] arrayRndNum = CreateRandomArray(Length);
int countEvnNum = CountEvenNumbers(arrayRndNum);
Console.WriteLine($"В массиве чисел {PrintArray(arrayRndNum)} четных чисел {countEvnNum}"); 