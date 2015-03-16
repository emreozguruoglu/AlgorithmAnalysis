/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package ınsertionsort;

import java.util.Random;


public class InsertionSort {

    public static int swap = 0;
    public static int karsilastir = 0;
    
    public static void main(String[] args) {
     
     int[] input = new int[500];
     int sayi = 0;
     Random randomGenerator = new Random();
     
     for (int i = 0; i < 500; i++) {
            sayi  = randomGenerator.nextInt(10000);
            input[i] = sayi;
        }
     
     insertionSort(input);
     
        
        
        for (int i = 0; i < input.length; i++) {
            System.out.println(input[i]);
        }
        System.out.println("\n");
        System.out.println("karsilastirma :" + karsilastir);
        System.out.println("swap :" + swap);
    
}

    private static void insertionSort(int[] input) {
     int j;                     // the number of items sorted so far
     int key;                // the item to be inserted
     int i;  
     
     for (j = 1; j < input.length; j++)    // Start with 1 (not 0)
    {
           
           key = input[ j ];
           for(i = j - 1; (i >= 0) && (input[ i ] < key); i--)   // Smaller values are moving up
          {
                 input[ i+1 ] = input[ i ];
                 swap=swap+1;
                 karsilastir=karsilastir+1;
          }
          karsilastir=karsilastir+1;
          
         input[ i+1 ] = key;    // Put the key in its proper location
     }
    }
}
