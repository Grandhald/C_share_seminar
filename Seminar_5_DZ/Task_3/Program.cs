// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double InputDouble (string message) 
{   
  Console.WriteLine(message);
  double number = Convert.ToDouble(System.Console.ReadLine());
  return number;
}

int InputInt (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

double [] CreateRandomArray(int len, double min, double max)
{   
    double [] numbers = new double [len];
    Random rdn = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(rdn.NextDouble() * (max -min)-min, 3);
    }   
    return numbers;
}

string PrintArray (double [] array)
{
    string massifPrint = "[";
    foreach (double item in array)
    {
        massifPrint += $"{item}, ";
    }
    return massifPrint.Substring(0, massifPrint.Length-2)+"]";
}

double MaxElemArray (double [] array)
{
    double max = array[0];
    foreach (double item in array)
    {
        if (max<item)
        {
            max = item;
        }
    }
    return max;
}

double MinElemArray (double [] array)
{
    double min = array[0];
    foreach (double item in array)
    {
        if (min>item)
        {
            min = item;
        }
    }
    return min;
}

int length = InputInt("Введите количество элементов в массиве: ");
double minRnd = InputDouble("Введите минимальный порог случайных значений: ");
double maxRnd = InputDouble("Введите максимальный порог случайных значений: "); 
double [] array = CreateRandomArray(length, minRnd, maxRnd);
double maxNumArray = MaxElemArray(array); double minNumArray = MinElemArray(array);
double  diffMaxMin = maxNumArray-minNumArray;
Console.WriteLine($"Максимальный элемент массива {PrintArray(array)} => {maxNumArray}. Минимальный элемент => {minNumArray}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {PrintArray(array)} ровна {diffMaxMin}");
