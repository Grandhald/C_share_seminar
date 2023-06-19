string Inputed (string message) 
{   
  Console.WriteLine(message);
  string number = System.Console.ReadLine();
    if (number.Length == 5) 
    {
        return number;
    } 
    else
    {
        System.Console.WriteLine("Вы ввели неверные данные. Попробуйте еще раз.");
        return Inputed(message);
    }
}

string number = Inputed("Введите пятизначное число:");

char [] reverse(string number)
{
    char [] reverse = number.ToCharArray().Reverse().ToArray();
    return reverse; 

}
Console.WriteLine(reverse(number));   