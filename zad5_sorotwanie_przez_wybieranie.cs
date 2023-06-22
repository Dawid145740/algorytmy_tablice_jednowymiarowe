using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int Rozmiar = 10;
        int[] tab = new int[Rozmiar];

        for (int i = 0; i < Rozmiar; i++)
        {
            tab[i] = random.Next(100);
        }

        Console.WriteLine("Nieposortowana tablica:");
        PrintArray(tab);

        BubbleSort(tab);

        Console.WriteLine("Posortowana tablica:");
        PrintArray(tab);
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
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}
