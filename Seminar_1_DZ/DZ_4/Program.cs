Console.WriteLine("Введите число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>1) {
    for (int i = 0; i<number-1; i+=2){
        Console.Write($"{i+2} ");
    }
}
else {
    Console.WriteLine("Ошибка, неверно введенные данные");
}