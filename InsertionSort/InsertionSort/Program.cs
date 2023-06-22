using System;
public class InsertionSort
{
    public static void Main()
    {
        // Insertion sort = after comparing elements to the left,

        //				shift elements to the right to make room to insert a value
        //				Quadratic time O(n^2)
        //				small data set = decent
        //				large data set = BAD

        //				Less steps than Bubble sort
        //				Best case is O(n) compared to Selection sort O(n^2)


        Console.WriteLine("Performing insertion Sort");
        Console.WriteLine("Enter the number of elements:");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements : ");
        int[] arr = new int[a];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Starting insertion Sort");
        PrintArray(arr);

        Console.WriteLine("After insertion Sort");
        Insertion(arr);
        // call new method for insertion sorting;
        PrintArray(arr);
        // 8 , 2 , 5, 3, 9, 4 , 7 ,6 ,1
    }

    public static void Insertion(int[] arr)
    {
        for(int i = 1; i < arr.Length; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while(j >= 0 && arr[j] > temp) 
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
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