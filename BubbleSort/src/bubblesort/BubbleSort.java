/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bubblesort;

import java.util.Random;

/**
 *
 * @author BM
 */
public class BubbleSort {
   public static int swap=0;
   public static int comparison=0;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        long startTime = System.currentTimeMillis(); 
        int[] dizi = new int[500];
        Random randomGenerator = new Random();
        int sayi = 0;
        for (int i = 0; i < 500; i++) {          
            sayi= randomGenerator.nextInt(10000);
            dizi[i]=sayi;
        }
        BubbleSort(dizi);
        for (int i = 1; i < 500; i++) {
             System.out.println(dizi[i]);
        }
        long endTime = System.currentTimeMillis();
        long estimatedTime = endTime - startTime; // Geçen süreyi milisaniye cinsinden elde ediyoruz
        double seconds = (double)estimatedTime/1000; //
        System.out.println(seconds);
        System.out.println("Swap: "+ swap);
        System.out.println("Comparison :"+comparison);

    }

    public static void BubbleSort(int[] dizi) {
        int temp;   // Yer değiştirmede kullanılacak geçici değişken
        for (int i = 1; i < dizi.length; i++) {
            for (int j = 0; j < dizi.length - i; j++) {
                if (dizi[j] > dizi[j + 1]) {
                    temp = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi[j + 1] = temp;
                    swap++;
                }
                comparison++;//Önce gelen elaman bir sonrakinden büyükse ikisi yer değiştiriyor
            }// Dizinin ardışık elamanlarını karşılaştırmak için kullandığımız döngü
        }// Her karşılaştırmadan sonra yeniden kaldığımız yerden devam etmemizi sağlayan döngü

    }

}