namespace egzaminWartownik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = TabWartownik.Wypelnij(100);
            Console.WriteLine("Podaj szukana liczbe");
            var szukanaString = Console.ReadLine();
            int szukana = int.Parse(szukanaString);
            TabWartownik.Szukanie(tablica,szukana);

        }
    }
}
