Console.WriteLine("Введите первое число: ");
string inputFist = Console.ReadLine();
int numberFirst = Convert.ToInt32(inputFist);
Console.WriteLine("Введите второе число: ");
string inputSecond = Console.ReadLine();
int numberSecond = Convert.ToInt32(inputSecond);
if (numberFirst>numberSecond) {
    Console.WriteLine($"Число {numberFirst} большее");
}
if (numberSecond>numberFirst) {
    Console.WriteLine($"Число {numberSecond} большее");
}
else {
    Console.WriteLine("Оба числа равны");
}