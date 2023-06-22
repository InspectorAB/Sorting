using System;
public class SelectionSort
{
    public static void Main()
    {
        // selection sort = search through an array and keep track of the minimum value during 
        //			     each iteration. At the end of each iteration, we swap values.
        //				 Quadratic time O(n^2)
        //				 small data set = okay
        //				 large data set = BAD


        Console.WriteLine("Performing selection Sort");
        Console.WriteLine("Enter the number of elements:");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements : ");
        int[] arr = new int[a];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Starting selection Sort");
        PrintArray(arr);

        Console.WriteLine("After selection Sort");
        Selection(arr);
        // call new method for selection sorting;
        PrintArray(arr);
        // 8 , 2 , 5, 3, 9, 4 , 7 ,6 ,1
    }

    public static void Selection(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[min] > arr[j])
                {
                    min = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
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
