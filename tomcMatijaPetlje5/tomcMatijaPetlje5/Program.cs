using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje5
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 1;
            int zbroj = 0;
            for (int i = 1; i <= 500; )
            {
                if (br % 2 != 0)
                {
                    i++;
                    zbroj += br;

                }
                br++;
            }
            Console.WriteLine("Zbroj prvih 500 neparnih brojeva je: " + zbroj);
            Console.ReadKey();
        }
    }
}
