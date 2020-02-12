using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje1
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            if (niz.Length < 5)
            {
                Console.WriteLine(niz);
            }
            else
            {
                string newNiz = niz.Remove(0, 2);
                newNiz = newNiz.Remove(newNiz.Length - 2);

                Console.WriteLine(newNiz);
            }

            Console.ReadKey();
        }
    }
}