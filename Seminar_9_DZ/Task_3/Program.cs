// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double Inputed(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(System.Console.ReadLine());
    return number;
}
double FunctionAkkerman(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
}

double m = Inputed("Введите значение m: ");
double n = Inputed("Введите значение n: ");

Console.WriteLine();

Console.WriteLine($"Значение функции Аккермана при m = {m} и n = {n} --> {FunctionAkkerman(m, n)}");
