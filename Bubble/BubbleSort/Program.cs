// See https://aka.ms/new-console-template for more information
using System;
public class BubbleSort
{
    public static void Main()
    {
        Console.WriteLine("Performing Bubble Sort");
        Console.WriteLine("Enter the number of elements:");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements : ");
        int[] arr = new int[a];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Starting Bubble Sort");
        PrintArray(arr);

        Console.WriteLine("After Bubble Sort");
        BubbleSorting(arr);
        // call new method for bubble sorting;
        PrintArray(arr);

    }

    public static void BubbleSorting(int[] arr)
    {
        int a = arr.Length;
        bool swapped;

        for(int i=0; i< a - 1; i++)
        {
            swapped = false;
            for(int j=0; j < a - i - 1;j++)
            {
                if (arr[j] > arr[j+1]) 
                {
                    // creating a temp variable to store the higher value and moving across
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                    swapped = true;
                }
            }
            if(!swapped) { break; }
        }
    }


    public static void QuickSorting(int[] arr)
    {

    }

    public static void PrintArray(int[] arr)
    {
        foreach(var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
