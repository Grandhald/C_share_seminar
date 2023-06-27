// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Inputed(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(System.Console.ReadLine());
    return number;
}

double[] Intersection(double kOne, double kTwo, double bOne, double bTwo)
{
    double[] coordinats = new double[2];
    double x = (bOne - bTwo) / (kTwo - kOne); double y = kOne * x + bOne;
    coordinats[0] = x; coordinats[1] = y;
    return coordinats;
}

void PrintArray(double[] array)
{
    string massifPrint = "[";
    foreach (double item in array)
    {
        massifPrint += $"{item}, ";
    }
    Console.WriteLine(massifPrint.Substring(0, massifPrint.Length - 2) + "]");
}

double bOne = Inputed("Введите значение B1: "); double kOne = Inputed("Введите значение K1: ");
double bTwo = Inputed("Введите значение B2: "); double kTwo = Inputed("Введите значение K2: ");

double[] coordPoint = Intersection(kOne, kTwo, bOne, bTwo);
PrintArray(coordPoint);