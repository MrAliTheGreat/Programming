package com.MrAli;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.println("How Many Numbers Do You Want? \r");
        int number = scanner.nextInt();
        int[] myIntArray = getIntegers(number);
        printArray(myIntArray);
        System.out.println("\n");
        printArray(sortIntegers(myIntArray));
    }

    private static int[] getIntegers(int number){
        System.out.println("Please Enter Your Numbers: \r");
        int[] intValues = new int[number];
        for (int i=0 ; i<intValues.length ; i++){
            intValues[i]= scanner.nextInt();
        }
        return intValues;
    }

    private static void printArray(int[] intArray){
        for (int i=0 ; i<intArray.length ; i++){
            System.out.println("The " + i + "th number is: " + intArray[i]);
        }
    }

    private static int[] sortIntegers(int[] oldArray){
        int helpVariable;
        for (int i=0 ; i<oldArray.length ; i++){
            for (int j=0 ; j<oldArray.length-1 ; j++){
                if (oldArray[j]<oldArray[j+1]){
                    helpVariable=oldArray[j];
                    oldArray[j]=oldArray[j+1];
                    oldArray[j+1]=helpVariable;
                }
            }
        }
        return oldArray;
    }
}
