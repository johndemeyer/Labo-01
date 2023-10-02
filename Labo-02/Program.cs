namespace Labo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deel-01
            float PiF = 3.14F;
            Console.WriteLine("De waarde van PI");
            Console.WriteLine(PiF);

            // deel-02
            Console.WriteLine("");
            decimal dec = 2000.25M;
            Console.WriteLine("Dit is een decimaal");
            Console.WriteLine(dec);

            // deel-03
            int maxInt = int.MaxValue;
            Console.WriteLine("");
            Console.WriteLine("de waarde van maxInt");
            Console.WriteLine(maxInt);

            // deel-04
            // dit geeft verkeerd resultaat,
            // omdat we de waarde van maxInt met 1 verhogen,
            // we duwen de bits door en krijgen nu het kleinste int
            // om een juist resultaat te bekomen moeten we nog een variable declaren
            // van het datatype long
            Console.WriteLine("");
            Console.WriteLine("de verkeerde waarde van maxInt +1, we verhogen de variable");
            Console.WriteLine(++maxInt);

            Console.WriteLine("");
            Console.WriteLine(" de waarde van de maxInt");
            int newMaxInt = int.MaxValue;
            Console.WriteLine(newMaxInt);
            // dit verhoogd de variable weer
            // long newLong = (++newMaxInt);
            Console.WriteLine("");
            Console.WriteLine("de waarde van de long");
            // 1 van de waarden moet een long zijn, anders verwerking als int
            long newLong = 1L + newMaxInt;
            Console.WriteLine(newLong);

            // deel-05
            ushort maxUShort = ushort.MaxValue;
            Console.WriteLine("");
            Console.WriteLine("de waarde van mxUshort");
            Console.WriteLine(maxUShort);
            // dit kan, het is MaxUshort + 1, console.writeline maakt er een int van
            // de value van maxUshort is niet aangepast
            Console.WriteLine("");
            Console.WriteLine("de juiste waarde van een mxUShort +1, variable is niet verhoogd");
            Console.WriteLine(maxUShort + 1);
            // dit klopt niet, want het is een overload van de short val
            // we ztten hier de waarde van maxUshort met 1 hoger, wat niet kan
            // op de achter grond worden alle bits door geduwd en we krijgen nu nul
            //
            Console.WriteLine("");
            Console.WriteLine("een verkeerde weergave van maxUShort, variable is verhoogd");
            Console.WriteLine(++maxUShort);
            


        }
    }
}