// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double Inputed (string message) 
{   
  Console.WriteLine(message);
  double number = Convert.ToDouble(System.Console.ReadLine());
  return number;
}

double Pow(double number, double power)
{
    double numPow = 1;
    for (int i = 0; i < power; i++)
    {
        numPow *= number;
    }
    return numPow;
}
 
 double number = Inputed("Введите число: ");
 double power = Inputed("Введите степень числа: ");
 double numberPow = Pow(number, power);
 Console.WriteLine($"Число {number} в степени {power} ровно {numberPow}");
 

