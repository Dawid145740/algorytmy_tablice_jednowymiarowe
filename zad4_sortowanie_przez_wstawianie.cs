using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int rOZMIAR, i;

        rOZMIAR = 10;
        int[] tab = new int[rOZMIAR];

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            tab[i] = random.Next(100);
        }

        Console.WriteLine("Nieposortowana tablica:");
        for (i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }


        InsertionSort(tab);

        Console.WriteLine("Posortowana tablica:");
        for (i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }

    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }
}
