//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//(*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

int [] CreateArray(int len)
{
    int [] numbers = new int [len];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Введите значение {i+1}-го элемента массива: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

int [] CreateRandomArray(int len, int min, int max)
{
    int [] numbers = new int [len];
    Random rdn = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rdn.Next(min,max);
    }   
    return numbers;
}

void PrintArray (int [] array)
{
    string massifPrint = "[";
    foreach (int item in array)
    {
        massifPrint += $"{item}, ";
    }
    Console.WriteLine(massifPrint.Substring(0, massifPrint.Length-2)+"]");
}
int Length = Inputed("Введите длину массива: ");
int min = Inputed("Введите минимальный порог случайных значений: ");
int max = Inputed("Введите максимальный порог случайных значений: ");
int [] arrayNumbers = CreateArray(Length);
int [] arrayRandomNumbers = CreateRandomArray(Length, min, max);
PrintArray(arrayNumbers);
PrintArray(arrayRandomNumbers);


