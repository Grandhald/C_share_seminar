// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int SumNumbersInterval(int start, int finish)
{
    if (start > finish)
    {
        return 0;
    }
    return start + SumNumbersInterval(start + 1, finish);
}

int initValue = Inputed("Введите начальное значение: ");
int finalValue = Inputed("Введите конеченое значение: ");

Console.WriteLine();

Console.WriteLine($"Сумма натуральных чисел от {initValue} до {finalValue} --> {SumNumbersInterval(initValue, finalValue)}");
