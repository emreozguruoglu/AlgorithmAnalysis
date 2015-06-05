using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1 };

            int gecici = 0;
            int sayac = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                while (dizi[i] == 0)
                {
                    if (dizi[i] == dizi[i + 1])
                    {
                        sayac = sayac + 1;
                        gecici = sayac;
                        break;
                    }
                    else
                    {
                        sayac = 1;
                        break;
                    }
                }
            }

            if (sayac > gecici)
            {
                Console.WriteLine("Dizi'nin en çok sifir takip eden serisi:{0} tanedir.", sayac);
            }
            else
            {
                Console.WriteLine("Dizi'nin en çok takip eden 0 serisi:{0} tanedir.", gecici);
            }

            Console.ReadLine();


        }
    }
}
