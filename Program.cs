using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioJezelesHF
{
    class Program
    {
        public static  void Fel2(){
            int i = 0;
            Console.WriteLine("Mekora legyena a tomb");
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            do
            {               
                Console.WriteLine("Sza mok");
                a[i] = int.Parse(Console.ReadLine());
                i++;
            } while (i!=N);

            int sum = 0;
            for (int s = 0; s < a.Length; s++)
            {
                sum += a[s];
            }
            Console.WriteLine("átlag:{0} ",sum/a.Length);
            int max = a[0];
            for (int ss = 0;ss < a.Length; ss++)
            {
                if (a[ss]>max)
                {
                    max = a[ss];
                }
            }
            Console.WriteLine("Max: " + max);
            int min = a[0];
            for (int sss = 0; sss < a.Length; sss++)
            {
                if (a[sss] < min)
                {
                    min = a[sss];
                }
            }


            Console.WriteLine("Min: "+min);

        }
        static void Main(string[] args)
        {
            Fel2();

            Console.ReadKey();
        }
    }
}
