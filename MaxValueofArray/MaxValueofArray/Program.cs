using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueofArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch watch = new Stopwatch(); // Programın çalışma süresini öğrenebilmek için Stopwatch fonksiyonundan yararlanıldı

            int maxValue = 0; // Maximum sayinin atanacagi deger burada tutulacaktir.
            int thisNum=0; // Dizi elemanlarinin degerleri kiyaslanmak icin burada tutulacaktir.
            int[] dizi = new int[9]; // Kullanici tarafindan girilecek dizi elemanlari buraya eklenecektir.
            
            for (int i = 0; i < dizi.Length; i++) // 9 tane eleman kullanicidan okutuldu.
			{
			    Console.Write("Lütfen dizinin {0}. elemanini giriniz: " , i+1);
	            dizi[i] = Convert.ToInt32(Console.ReadLine());
			}

            watch.Start(); // Sure baslatildi.

            for (int j = 0; j < dizi.Length; j++) // Dizinin maximum elemani bu for döngüsü ile bulunacaktir.
            {
                
                thisNum = dizi[j];
                if (maxValue <= thisNum)
                {
                    maxValue = thisNum; // Maximum değer eğer daha büyük bir şey ile kiyaslandiysa burada degistirilecektir.
                }
            }

            watch.Stop(); // Süre durduruldu.
            
            Console.WriteLine("Verilen dizinin maximum elemanı: {0} ' dir.", maxValue); //Dizinin maximum degeri ekrana yazdirildi.
            
            TimeSpan timer = watch.Elapsed; //Süre değerlerine erişmek için timer değişkeni oluşturuldu.
            
            Console.Write("Programin calisma süresi: ");
            
            string sonuc = String.Format("{0} sa :{1} dk :{2} sn :{3} ms ' dir.", timer.Hours, timer.Minutes, timer.Seconds, timer.TotalMilliseconds * 1000000);//Süre saat,dakika,saniye ve milisaniye olarak gösterildi
            
            Console.Write(sonuc); //Ekrana sonuç yazdırıldı
            
            Console.ReadLine(); // Sistem sonucu bize anlık göstermesin diye ekranda enter a basana kadar bekleyebilmemiz icin bu satir yazildi.
        
        }
    }
}
