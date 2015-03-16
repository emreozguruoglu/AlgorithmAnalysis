/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package shellsort;

import java.util.Random;

/**
 *
 * @author BM
 */
public class ShellSort {
    public static int swap = 0;
    public static int karsilastir = 0;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       int[] input = new int[500];
     int sayi = 0;
     Random randomGenerator = new Random();
     
     for (int i = 0; i < 500; i++) {
            sayi  = randomGenerator.nextInt(10000);
            input[i] = sayi;
        }
     
        ShellSort(input);
     
        
        
        for (int i = 0; i < input.length; i++) {
            System.out.println(input[i]);
        }
        System.out.println("\n");
        System.out.println("karsilastirma :" + karsilastir);
        System.out.println("swap :" + swap);
    }

    public static void ShellSort( int [ ] a )
    {
        for( int gap = a.length / 2; gap > 0;
                     gap = gap == 2 ? 1 : (int) ( gap / 2.2 ) )
            for( int i = gap; i < a.length; i++ )
            {
                Comparable tmp = a[ i ];
                int j = i;

                for( ; j >= gap && tmp.compareTo( a[ j - gap ] ) < 0; j -= gap ){
                    a[ j ] = a[ j - gap ];
                    swap=swap+1;}
                karsilastir=karsilastir+1;
                a[ j ] = (int) tmp;
            }
    }
    
}
