using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {  
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int[] arr = new int[10]; // Dizi elemanlari arr dizi değişkenine eklenecektir.

            for (int i = 0; i < arr.Length; i++) // 10 tane eleman random olarak oluşturuldu.
            {
                arr[i] = rnd.Next(100); // 0 ile 100 arasında random sayılar oluşturuluyor.
            }

            HeapSort hs = new HeapSort();
            hs.PerformHeapSort(arr);
            Console.ReadLine();
        }
    }

    class HeapSort
    {

        public static int swapnubmer = 0;
        private int heapSize;

        private void BuildHeap(int[] arr)
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Swap(int[] arr, int x, int y) //Dizi elamanlari swap yapilir.
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(int[] arr, int index) //Dizi elemanlari burada düzenlenir.
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                swapnubmer = swapnubmer + 1;
                Heapify(arr, largest);
            }
        }

        public void PerformHeapSort(int[] arr)
        {
            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
            DisplayArray(arr);
        }

        private void DisplayArray(int[] arr) //Dizi ekrana yazdirilir.
        {
            for (int i = 0; i < arr.Length; i++)
            { Console.Write("[{0}]", arr[i]); }
            Console.WriteLine();

            Console.Write("Dizide toplam {0} adet swap yapilmistir.", swapnubmer);
        }
    }
}
