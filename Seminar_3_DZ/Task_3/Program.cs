// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int RedInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ExponentPrint(int number, double pow)
{
    for (int i = 1; i < number+1; i++)
    {
        double exp = Math.Pow(i, pow);
        Console.WriteLine(exp);
    }
}

int number = RedInt("Введите число: ");
ExponentPrint(number, 3);
