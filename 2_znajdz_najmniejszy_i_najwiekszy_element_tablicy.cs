using System;

public class Program
{
    public static void Main()
    {
        int[] tablica = { 4, 8, 5, 3, 1 };

        int najmniejszy = tablica[0];
        int największy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
                najmniejszy = tablica[i];

            if (tablica[i] > największy)
                największy = tablica[i];
        }

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + największy);
    }
}