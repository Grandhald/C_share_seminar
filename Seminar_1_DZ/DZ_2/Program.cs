Console.WriteLine("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());
int max = numberFirst;
if (numberSecond>max){
    max = numberSecond;
}
if (numberThird>max) {
    max = numberThird;
}
Console.WriteLine($"Максимальное число {max}");