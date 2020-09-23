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
            int[] a = new int[10];
            do
            {
                Console.WriteLine("Szamok");
                a[i] = int.Parse(Console.ReadLine());
                i++;
            } while (i!=10);

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum+=
            }

        }
        static void Main(string[] args)
        {
            Fel2();

            Console.ReadKey();
        }
    }
}
