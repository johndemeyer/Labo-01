using System;

namespace Labo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            string d = Convert.ToString(c);
            // oke - Console.WriteLine(c);
            // deze is korter, in de console classe zit functie om te converteren
            Console.WriteLine(a + b);

            // labo-02
            double aa = 2.3;
            double bb = 4.4;
            double cc = aa + bb;    
            string dd = Convert.ToString(cc);
            Console.WriteLine(dd);

            // labo-03
            Console.WriteLine("type een tekst");
            string aaa = Console.ReadLine();
            Console.WriteLine(aaa);
             

            // labo-04
            Console.WriteLine("geef eerste getal");
            double getala = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef een tweede getal");
            double getalb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getala + getalb);



        }
    }
}