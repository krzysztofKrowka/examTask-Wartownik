using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzaminWartownik
{
    public class TabWartownik
    {
        /// <summary>
        /// Funkcja wypełnia tablicę pseudolosowymi liczbami od 1 do 100
        /// </summary>
        /// <param name="tabLen">Długość tablicy</param>
        /// <returns>Wypełniona tablica</returns>
        public static int[] Wypelnij(int tabLen)
        {
            Random rnd = new Random();
            var tab = new int[tabLen + 1];
            for (int i = 0; i < tabLen; i++)
                tab[i] = rnd.Next(1, 101);
            return tab;
        }
        /// <summary>
        /// Funkcja szuka podanego elementu w podanej tablicy
        /// </summary>
        /// <param name="tab">Tablica</param>
        /// <param name="szukana">Szukana liczba</param>
        /// <returns>Indeks szukanego elementu</returns>
        public static int Szukanie(int[] tab,int szukana)
        {
            
            int indeks = 0;
            tab[tab.Length - 1] = szukana;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == szukana)
                {
                    indeks = i;
                    break;
                }
            }
            for (int i = 0; i < tab.Length - 1; i++)
            {
                Console.Write(tab[i]);
                if (i != tab.Length - 2)
                    Console.Write(", ");

            }
            if (indeks != tab.Length - 1)
                Console.WriteLine("\nPodana liczba znajduje się na indeksie: " + indeks);
            else
                Console.WriteLine("\nSzukanej liczby nie ma w tablicy");
            return indeks;
        }
    }
}
