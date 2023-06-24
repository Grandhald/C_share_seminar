//Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

int [] CreateRandomArray(int len,int min, int max)
{
    int [] numbers = new int [len];
    Random rdn = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rdn.Next(min, max);
    }   
    return numbers;
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

int SumOddPosNum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int Length = Inputed("Введите количество элементов в массиве: ");
int min = Inputed("Введите минимальный порог случайных значений: ");
int max = Inputed("Введите максимальный порог случайных значений: ");
int [] arrayNum = CreateRandomArray(Length, min, max);
int sumOddPosNum = SumOddPosNum(arrayNum);
Console.WriteLine($"Сумма элементов в массиве {PrintArray(arrayNum)} стоящих на нечетных позициях ровна {sumOddPosNum}");