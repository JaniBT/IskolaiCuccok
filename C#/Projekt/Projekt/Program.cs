using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamketto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg, hogy milyen műveletet akarsz elvégezni (/*-+): ");
            string muvelet = Console.ReadLine();
            if (muvelet == "/")
            {
                int oszt = szam / szamketto;
                Console.WriteLine("Az eredmény: ", oszt);
            }
            else if (muvelet == "*")
            {
                int szoroz = szam * szamketto;
                Console.WriteLine("Az eredmény: ", szoroz);
            }
            else if (muvelet == "-")
            {
                int kivon = szam - szamketto;
                Console.WriteLine("Az eredmény: ", kivon);
            }
            else if (muvelet == "+")
            {
                int osszead = szam + szamketto;
                Console.WriteLine("Az eredmény: ", osszead);
            }
            else
            {
                Console.WriteLine("Csak megadott műveleti jeleket adhatsz meg!");
            }
        }
    }
}