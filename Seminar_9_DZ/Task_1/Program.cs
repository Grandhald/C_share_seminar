// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

void IntervalOfEvenNumbers(int start, int finish)
{
    if (start % 2 != 0)
    {
        start++;
    }
    if (start>finish)
    {
        return;
    }
    Console.Write(start + "\t");
    IntervalOfEvenNumbers(start+2, finish);
}

int initValue = Inputed("Введите начальное значение: ");
int finalValue = Inputed("Введите конеченое значение: ");

Console.WriteLine();

IntervalOfEvenNumbers(initValue, finalValue);
