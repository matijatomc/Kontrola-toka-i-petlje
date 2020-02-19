using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite broj i program ce napisat dali se duplaju znakovi");
            int velicina;
            int br = Convert.ToInt32(Console.ReadLine());
            velicina = br.ToString().Length;
            int[] arr = new int[velicina];
            int counter = 0;
            while (br != 0)
            {
                int temp = br;
                br = br / 10;
                arr[counter] = temp - (br * 10);
                counter++;
            }
            bool ima = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            ima = true;

                        }
                    }
                }
            }
            if (ima == true)
            {
                Console.WriteLine("Ne");
            }
            else
            {
                Console.WriteLine("Da");
            }
            Console.ReadKey();
        }
    }
}
