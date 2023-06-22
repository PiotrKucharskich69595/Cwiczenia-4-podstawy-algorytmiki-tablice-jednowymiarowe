using System;

public class Program
{
    public static void Main()
    {
        int[] tablica = { 4, 2, 1, 7, 6 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    public static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        for (int i = 0; i < n - 1; i++)
        {
            zamiana = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    ZamienElementy(tablica, j, j + 1);
                    zamiana = true;
                }
            }

            if (!zamiana)
                break;
        }
    }

    public static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    }

    public static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}