using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 beírásával léphet ki a programból!");
            Console.Write("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamketto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg, hogy milyen műveletet akarsz elvégezni (/*-+): ");
            string muvelet = Console.ReadLine()!;

            int eredmeny = 0;
                if (muvelet == "/")
                {
                    eredmeny = szam / szamketto;
                }
                else if (muvelet == "*")
                {
                    eredmeny = szam * szamketto;
                }
                else if (muvelet == "-")
                {
                    eredmeny = szam - szamketto;
                }
                else if (muvelet == "+")
                {
                    eredmeny = szam + szamketto;
                }
                else
                {
                    Console.WriteLine("Csak megadott műveleti jelet adhatsz meg!");
                }

                if (eredmeny != 0)
                {
                    Console.WriteLine($"Az eredmény: {eredmeny}");
                }
            Console.ReadKey();
        }
    }
}