using System;

using System.Collections.Generic;

using System.Text;



namespace CSharpSort
{

    class Program
    {



        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {

            int[] temp = new int[25];

            int i, left_end, num_elements, tmp_pos;



            left_end = (mid - 1);

            tmp_pos = left;

            num_elements = (right - left + 1);



            while ((left <= left_end) && (mid <= right))
            {

                if (numbers[left] <= numbers[mid])

                    temp[tmp_pos++] = numbers[left++];

                else

                    temp[tmp_pos++] = numbers[mid++];

            }



            while (left <= left_end)

                temp[tmp_pos++] = numbers[left++];



            while (mid <= right)

                temp[tmp_pos++] = numbers[mid++];



            for (i = 0; i < num_elements; i++)
            {

                numbers[right] = temp[right];

                right--;

            }

        }



        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {

            int mid;

            if (right > left)
            {

                mid = (right + left) / 2;

                MergeSort_Recursive(numbers, left, mid);

                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);

            }

        }





        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10]; // Dizi elemanlari arr dizi değişkenine eklenecektir.
            
            for (int i = 0; i < numbers.Length; i++) // 10 tane eleman random olarak oluşturuldu.
            {
                numbers[i] = rnd.Next(100); // 0 ile 100 arasında random sayılar oluşturuluyor.
            }

            int len = 9;



            Console.WriteLine("MergeSort By Recursive Method");

            MergeSort_Recursive(numbers, 0, len - 1);

            for (int i = 0; i < 9; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
