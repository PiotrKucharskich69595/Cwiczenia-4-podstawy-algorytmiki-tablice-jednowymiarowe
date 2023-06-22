using System;

public class MyProgram
{
    private static Random random = new Random();
    
    public static void Main(string[] args)
    {
        int ROZMIAR, i;
        
        ROZMIAR = 10;
        int[] tab = new int[ROZMIAR];
        
        for (i = 0; i <= ROZMIAR - 1; i++)
        {
            tab[i] = random.Next(100);
        }
        for (i = 0; i <= ROZMIAR - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }
        int indeksNajmniejszegoElementu;
        
        indeksNajmniejszegoElementu = 0;
        int pozycjaDoZapisu;
        
        for (pozycjaDoZapisu = 0; pozycjaDoZapisu <= ROZMIAR - 1; pozycjaDoZapisu++)
        {
            indeksNajmniejszegoElementu = pozycjaDoZapisu;
            for (i = pozycjaDoZapisu + 1; i <= ROZMIAR - 1; i++)
            {
                if (tab[i] < tab[indeksNajmniejszegoElementu])
                {
                    indeksNajmniejszegoElementu = i;
                }
            }
            int najmniejszaWartosc;
            
            najmniejszaWartosc = tab[indeksNajmniejszegoElementu];
            tab[indeksNajmniejszegoElementu] = tab[pozycjaDoZapisu];
            tab[pozycjaDoZapisu] = najmniejszaWartosc;
        }
        for (i = 0; i <= ROZMIAR - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}
