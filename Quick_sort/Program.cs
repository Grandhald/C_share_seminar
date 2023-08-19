
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

int[] CreateRandomArray(int len, int min, int max)
{
    int[] numbers = new int[len];
    Random rdn = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rdn.Next(min, max);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    string massifPrint = "[";
    foreach (int item in array)
    {
        massifPrint += $"{item}, ";
    }
    Console.WriteLine(massifPrint.Substring(0, massifPrint.Length - 2) + "]");
}

int FindPivot(int[] array, int minIndex, int maxIndex)
{
    int temp = 0;
    int pivot = minIndex - 1;
    for (int i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            temp = array[i];
            array[i] = array[pivot];
            array[pivot] = temp;
        }
    }
    pivot++;
    temp = array[pivot];
    array[pivot] = array[maxIndex];
    array[maxIndex] = temp;
    return pivot; 
}

int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }
    int pivot = FindPivot(array, minIndex, maxIndex); 
    QuickSort(array, minIndex, pivot-1);
    QuickSort(array, pivot+1, maxIndex);

    return array;
}




int[] array = CreateRandomArray(100000, 0, 10);
int[] sortArray = QuickSort(array, 0, array.Length - 1);
PrintArray(sortArray);


