Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100>1 & number/100<10) {
    int SecondNumber = (number/10)%10;
    Console.WriteLine(SecondNumber);
}
else {
    Console.WriteLine("Это не трехначное число нет");
}
