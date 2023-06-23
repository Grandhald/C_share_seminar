//Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
//Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0

int[] GenerateArray(int len, int min, int max)		// Создает и наполняет массив
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArrey(int[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}

int count(int[] arrey)
{
    int num = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(100 > arrey[i] && arrey[i] > 9)
        {
            num++;
        }
    }
    return num;
}

int[] numberlist = GenerateArray(10, 1, 201);
PrintArrey(numberlist);
System.Console.WriteLine(count(numberlist));
