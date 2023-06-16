Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if (number.Length>2) {
    Console.WriteLine(number[2]);
}
else {
    Console.WriteLine("Третьей цифры нет");
}
