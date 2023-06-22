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

        BubbleSort(tab);

        Console.WriteLine("Posortowana tablica:");
        for (i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }

    public static void BubbleSort(int[] arr)
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
}
