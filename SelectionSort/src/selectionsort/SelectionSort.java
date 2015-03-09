/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package selectionsort;

import java.util.Random;

/**
 *
 * @author BM
 */
public class SelectionSort {
    public static int swap = 0;
    public static int karsilastir = 0;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        long startTime = System.currentTimeMillis();
        int[] dizi = new int[50];
        Random randomGenerator = new Random();
        int sayi = 0;
        for (int i = 0; i < 50; i++) {
            sayi = randomGenerator.nextInt(10000);
            dizi[i] = sayi;
        }
        selectionSort(dizi);
        for (int i = 1; i < 50; i++) {
            System.out.println(dizi[i]);
        }
        long endTime = System.currentTimeMillis();
        long estimatedTime = endTime - startTime; // Geçen süreyi milisaniye cinsinden elde ediyoruz
        double seconds = (double) estimatedTime / 1000; //
        System.out.println(seconds);
        System.out.println("karsilastirma :" + karsilastir);
        System.out.println("swap :" + swap);

    }

    public static void  selectionSort(int[] arr) {
        int i, j, minIndex, tmp;
        int n = arr.length;
        for (i = 0; i < n - 1; i++) {
            minIndex = i;
            for (j = i + 1; j < n; j++) {
                karsilastir++;
                if (arr[j] < arr[minIndex]) {
                    minIndex = j;
                }
            }
            if (minIndex != i) {
                tmp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tmp;
                swap++;
            }
           
        }

    }

}