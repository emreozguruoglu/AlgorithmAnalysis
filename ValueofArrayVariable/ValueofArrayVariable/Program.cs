﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueofArrayVariable
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch watch = new Stopwatch(); // Programın çalışma süresini öğrenebilmek için Stopwatch fonksiyonundan yararlanıldı

            int whichNum = 0;   //Dizide hangi index elemani istenildiyse o deger bu degiskende tutulacaktir.
            int[] dizi = new int[9]; // Kullanici tarafindan girilecek dizi elemanlari buraya eklenecektir.

            for (int i = 0; i < dizi.Length; i++) // 9 tane eleman kullanicidan okutuldu.
            {
                Console.Write("Lütfen dizinin {0}. elemanini giriniz: ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Lütfen girilen dizinin kacinci elemanini görmek istediginizi söyleyiniz? : ");
            whichNum = int.Parse(Console.ReadLine());

            watch.Start(); // Sure baslatildi.


            for (int j = 0; j < dizi.Length; j++)
            {
                if (whichNum==j) // İstenilen deger ile index degeri eslesmesi kontrol ediliyor.
                {
                    Console.WriteLine("Dizinini {0}. elemani = {1} 'dir", whichNum, dizi[j - 1]); // İstenilen dizi elemani ekrana yazildi.
                 }    
           }

            watch.Stop(); // Süre durduruldu.
            
            TimeSpan timer = watch.Elapsed; // Süre değerlerine erişmek için timer değişkeni oluşturuldu.

            Console.Write("Programin calisma süresi: ");

            string sonuc = String.Format("{0} sa :{1} dk :{2} sn :{3} ms ' dir.", timer.Hours, timer.Minutes, timer.Seconds, timer.TotalMilliseconds * 1000000);// Süre saat,dakika,saniye ve milisaniye olarak gösterildi

            Console.Write(sonuc); // Ekrana sonuc yazdirildi.

            Console.ReadLine(); // Sistem sonucu bize anlık göstermesin diye ekranda enter a basana kadar bekleyebilmemiz icin bu satir yazildi.
        
        }
    }
}
