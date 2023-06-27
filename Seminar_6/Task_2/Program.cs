// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int[] Fibbonaci(int number)
{
    int[] array = new int[number];
    if (number == 1)
    {
        return array;
    }
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}


void PrintArray(int[] array)
{
    string massifPrint = "[";
    foreach (int item in array)
    {
        massifPrint += $"{item}, ";
    }
    Console.WriteLine(massifPrint.Substring(0, massifPrint.Length - 2) + "]");
}


void Fib(int number, int one, int two)
{
    Console.WriteLine(one);
    int three = one+two;
    if (number > 1)
    {
        Fib(number-1, two, three);
    }
}

int number = Inputed("Введите число: ");
Fib(number, 0, 1);