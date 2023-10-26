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
            string muvelet = Console.ReadLine()!;

            Console.WriteLine(muvelet);

            if (muvelet == "/")
            {
                Console.WriteLine("Az eredmény: ", szam / szamketto);
            }
            else if (muvelet == "*")
            {
                
                Console.WriteLine("Az eredmény: ", szam * szamketto);
            }
            else if (muvelet == "-")
            {
                
                Console.WriteLine("Az eredmény: ", szam - szamketto);
            }
            else if (muvelet == "+")
            {
                
                Console.WriteLine("Az eredmény: ", szam + szamketto);
            }
            else
            {
                Console.WriteLine("Csak megadott műveleti jeleket adhatsz meg!");
            }
            Console.ReadKey();
        }
    }
}