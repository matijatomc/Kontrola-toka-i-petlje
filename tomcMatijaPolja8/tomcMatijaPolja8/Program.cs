using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPolja8
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0;
            Console.WriteLine("Upisujte vrijednosti karta u intervalu od 1 do 13 sve dog zbroj karta ne bude 31");
            while (!(zbroj > 30))
            {
                int br = Convert.ToInt32(Console.ReadLine());
                if (br > 0 && br < 14)
                {
                    zbroj = zbroj + br;
                }
                else
                {
                    Console.WriteLine("Upisao si broj koji nije u intervalu od 1-13");
                }



            }
            Console.WriteLine("Rezultat: " + zbroj);
            if (zbroj == 31) Console.WriteLine("Pobijedili ste");
            if (zbroj > 31) Console.WriteLine("Izgubili ste");
            Console.ReadKey();
        }
    }
}
