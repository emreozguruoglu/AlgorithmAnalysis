using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResize
{
    class Program
    {
        static int[] array;
        static int kapasite, boyut;

        public static void Main(string[] args)
        {

            Console.WriteLine("Bir Sayi Giriniz:");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            Random rand = new Random();
            kapasite = 4;
            array = new int[kapasite];
            for (boyut = 0; boyut < n; boyut++)
            {
                if (boyut > (kapasite - 1)) {
                    yeniBoyut();
                }
                array[boyut] = rand.Next();
            }
            print();
            Console.ReadLine();
        }

        static void yeniBoyut()
        {
            kapasite *= 2;
            int[] gecici = new int[kapasite];
            for (int i = 0; i < boyut; i++)
            {
                gecici[i] = array[i];
            }
            array = gecici;
            Console.WriteLine("Yeni Boyut:{0}", kapasite);
        }

        static void print()
        {
            for (int i = boyut; i > 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
