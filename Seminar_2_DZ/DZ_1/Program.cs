Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if (number.Length>1) {
    Console.WriteLine(number[1]);
}
else {
    Console.WriteLine("Второй цифры нет");
}
