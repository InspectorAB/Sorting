using System;
public class QuickSorting
{
    public static void Main()
    {
        Console.WriteLine("Performing quick Sort");
        Console.WriteLine("Enter the number of elements:");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements : ");
        int[] arr = new int[a];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Starting quick Sort");
        PrintArray(arr);

        Console.WriteLine("After quick Sort");
        QuickSort(arr, 0 , arr.Length-1);
        // call new method for quick sorting;
        PrintArray(arr);
        // 8 , 2 , 5, 3, 9, 4 , 7 ,6 ,1
    }

    public static void QuickSort(int[] arr, int start, int end)
    {
        if (end <= start) return; // we cant divide the array any more furher

        int pivot = partition(arr, start, end);
        QuickSort(arr, start, pivot - 1);
        QuickSort(arr, pivot+1, end);
    }

    public static int partition(int[] arr,int start, int end)
    {
        int pivot = arr[end];

        int i = start - 1;
        int temp;
        for(int j = start; j <= end - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        i++;
        temp = arr[i];
        arr[i] = arr[end];
        arr[end] = temp;

        return i;

    }
    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}