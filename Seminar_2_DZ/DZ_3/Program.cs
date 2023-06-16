Console.Write("Введите цифру обозначающие день недели: ");
int NumDayWeek = Convert.ToInt32(Console.ReadLine());
if (NumDayWeek / 6 == 1 || NumDayWeek / 7 == 1) {
    Console.WriteLine("Это день является выходным");
}
else {
    Console.WriteLine("Это день не является выходным");
}