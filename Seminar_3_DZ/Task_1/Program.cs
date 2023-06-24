// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
    if (number/10000>0 & number/10000<10) 
    {
        Console.WriteLine("gfds");
         return number;
    } 
   System.Console.WriteLine("Вы ввели неверные данные. Попробуйте еще раз.");
   return Inputed(message);
}

string ChekReverse(int number)
{
    string result = $"Число {number} является полиндромом";
    string tempNumber = $"{number}";
    for (int i = 0; i < tempNumber.Length/2; i++)
    {
        if (tempNumber[i] != tempNumber[tempNumber.Length-i-1])
        {
            result = $"Число {number} не является полиндромом";
            break;
        }
    }
    return result;
}

int number = Inputed("Введите пятизначное число:");

Console.WriteLine(ChekReverse(number));   