namespace pilotak
{
    public class Program
    {
        static List<string> mindenAdat;
        static List<string> pilotaNevek;

        static void Main(string[] args)
        {
            mindenAdat = File.ReadAllLines("Adatok\\pilotak.csv").Skip(1).ToList();

            pilotaNevek = File.ReadAllLines("Adatok\\pilotak.csv").Skip(1).Select(sor => sor.Split(';')[0]).ToList();

            Console.WriteLine($"3. feladat: {mindenAdat.Count}");

            Console.WriteLine($"4. feladat: {pilotaNevek.Last()}");
        }
    }
}