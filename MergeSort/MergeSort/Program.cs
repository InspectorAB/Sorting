using System;
using System.Globalization;

public class MergeSort
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
        MergeSorting(arr);
        // call new method for quick sorting;
        PrintArray(arr);
        // 8 , 2 , 5, 3, 9, 4 , 7 ,6 ,1
    }

    public static void MergeSorting(int[] arr)
    {
        int length = arr.Length;

        if (length <= 1) return;

        int middle = length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[length-middle];

        int i = 0; //left array
        int j =0;  //right array

        for(;i< length;i++)
        {
            if(i < middle)
            {
                leftArray[i] = arr[i];
            }
            else
            {
                rightArray[j] = arr[i];
                j++;
            }
        }
        MergeSorting(leftArray);
        MergeSorting(rightArray);
        merge(leftArray, rightArray, arr);
    }

    public static void merge(int[] leftarray, int[] rightarray, int[] array)
    {
        int leftSize = array.Length / 2;
        int rightSize = array.Length - leftSize;

        int i = 0, l = 0,r = 0;

        //check

        while(l < leftSize && r < rightSize) 
        {
            if (leftarray[l] < rightarray[r])
            {
                array[i] = leftarray[l];
                i++;
                l++;
            }
            else
            {
                array[i] = rightarray[r];
                i++;
                r++;
            }
        }
        while(l < leftSize)
        {
            array[i] = leftarray[l];
            i++;
            l++;
        }
        while(r < rightSize)
        {
            array[i] = rightarray[r]; i++;r++;
        }


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