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

        Console.WriteLine("Tablica:");
        for (i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }

        int min = tab[0];
        int max = tab[0];

        for (i = 1; i < rOZMIAR; i++)
        {
            if (tab[i] < min)
            {
                min = tab[i];
            }
            if (tab[i] > max)
            {
                max = tab[i];
            }
        }

        Console.WriteLine("Najmniejszy element: " + min);
        Console.WriteLine("Największy element: " + max);
    }
}
