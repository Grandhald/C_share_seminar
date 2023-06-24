// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double [] GenArrayPoint (int len = 3)
{   
    string axis = "xyz";
    double [] massif = new double[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите координаты точки по оси {axis[i]}: ");
        massif[i] = Convert.ToDouble(Console.ReadLine());
    }
    return massif;
}   

double Distance (double [] onePoint, double [] twoPoint)
{
    double sumSquareCoord = 0;
    for (int i = 0; i < onePoint.Length; i++)
    {
        sumSquareCoord += Math.Pow(onePoint[i]-twoPoint[i], 2);
    }
    double dist = Math.Pow(sumSquareCoord, 0.5);
    return dist;
}

string PrintArray (double [] array)
{
    string massifPrint = "[";
    foreach (int item in array)
    {
        massifPrint += $"{item}, ";
    }
    string arrayPrint = massifPrint.Substring(0, massifPrint.Length-2);
    arrayPrint += "]";
    return arrayPrint;
}
Console.WriteLine("Введите координаты первой точки");
double [] firstPoint = GenArrayPoint();
Console.WriteLine("Введите координаты второй точки");
double [] secondPoint = GenArrayPoint();
double distan = Distance(firstPoint, secondPoint);
Console.WriteLine($"Расстояние между точкой {PrintArray(firstPoint)} и точкой {PrintArray(secondPoint)} ровняется {distan}");





