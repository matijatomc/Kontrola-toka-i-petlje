using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi te neku godinu: ");
            int godina = Convert.ToInt32(Console.ReadLine());
            if (godina % 4 == 0)
            {
                Console.WriteLine("U godini " + godina + " održavaju se ljetne olimpijske igre");
            }
            else if ((godina - 2) % 4 == 0)
            {
                Console.WriteLine("U godini " + godina + " održavaju se zinske olimpijske igre");
            }
            else
            {
                Console.WriteLine("U godini " + godina + " ne održavaju se olimpijske igre");
            }

            Console.ReadKey();
        }
    }
}
