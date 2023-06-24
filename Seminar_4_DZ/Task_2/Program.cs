// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

int SumDigitsNumbers(int number)
{
    int sum = 0;
    while (number>0)
    {
      sum += number % 10;
      number /=  10;
    }
    return sum;
}

int num = Inputed("Введите число: ");
int sumDigit = SumDigitsNumbers(num);
Console.WriteLine(sumDigit); 
