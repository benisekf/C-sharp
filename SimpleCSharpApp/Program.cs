using System;
class Program
{
    static void Main()
    {
        int[] array = { 65, 34, 25, 13, 22 };
        Console.WriteLine("Original Array:");
        PrintArray(array);
        BubbleSort(array);
        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}