//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Inputed(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int CountPossitivNumbers(int numbers)
{
    int count = 0;

    for (int i = 0; i < numbers; i++)
    {
        int number = Inputed("Введите число");
        if (number > 0 && numbers > 0)
        {
            count++;
        }
    }
    return count;
}

int CntNumbers = Inputed("Введите количество вводимых числе: ");
int CntNumPos = CountPossitivNumbers(CntNumbers);
Console.WriteLine($"Количество позитивных чисел ---> {CntNumPos}");