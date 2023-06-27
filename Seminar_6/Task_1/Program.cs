// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Inputed (string message) 
{   
  Console.WriteLine(message);
  int number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}


string PrintArray (int [] array)
{
    string massifPrint = "[";
    foreach (int item in array)
    {
        massifPrint += $"{item}, ";
    }
    return massifPrint.Substring(0, massifPrint.Length-2)+"]";
}
int [] Result(int number)
{
    int [] array = new int [8];
    for (int i = array.Length-1; i >= 0; i--)
    {
        array[i] = number%2;
        number = number/2;
    }
    return array;
}
int number = Inputed("Введите число: ");
int [] massif = Result(number);
Console.WriteLine(PrintArray(massif));