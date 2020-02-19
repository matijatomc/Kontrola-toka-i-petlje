using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite URL od neke stranice:");
            string stranica = Console.ReadLine();
            if (stranica.Substring(0, 4) == "www.")
            {
                if (stranica.Substring(stranica.Length - 3) == ".hr")
                {
                    Console.WriteLine("Ovo je URL adrese registrirane u hrvatskom internetskom prostoru");
                }
                else
                {
                    Console.WriteLine("Ovo nije URL adrese registrirane u hrvatskom internetskom prostoru");
                }
            }
            else
            {
                Console.WriteLine("Ovo nije ispravan URL");
            }
            Console.ReadKey();
        }
    }
}
