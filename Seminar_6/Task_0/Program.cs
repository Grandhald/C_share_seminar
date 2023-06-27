// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

int a = Inputed("Введите длину стороны а");
int b = Inputed("Введите длину стороны b");
int c = Inputed("Введите длину стороны c");

string Chek(int a, int b, int c)
{
    if (a+b > c && b+c > a && c+a > b)
    {
        return "Даный треугольник может существовать";
    }
    return "Данный треугольник не может существовать";
}

Console.WriteLine(Chek(a, b, c));