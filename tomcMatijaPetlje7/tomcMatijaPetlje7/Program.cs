using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje7
{
    class Program
    {
        static void Main(string[] args)
        {
            int indikator;
            int brojac = 0;
            for (int i = 2; i <= 100; i++)
            {
                indikator= 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {

                        indikator = 1;
                        break;
                    }
                }

                if (indikator == 0)
                {
                    brojac++;
                }
            }
            Console.WriteLine("Broj primarnih brojeva koji su manji od 100 je: " + brojac);
            Console.ReadKey();
        }
    }
}
