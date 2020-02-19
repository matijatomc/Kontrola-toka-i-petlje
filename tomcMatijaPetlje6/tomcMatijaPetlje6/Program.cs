using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Unesi jednu rijec: ");
            text = Console.ReadLine();
            for (int i = text.Length; i > 0; i--)
            {
                Console.WriteLine(text.Substring(0, i));
            }
            Console.ReadKey();
        }
    }
}
