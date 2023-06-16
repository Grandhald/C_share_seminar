Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SecondNumber = (number/10)%10;
if (number/100>1) {
    Console.WriteLine(SecondNumber);
}
else {
    Console.WriteLine("Это не трехначное число нет");
}
