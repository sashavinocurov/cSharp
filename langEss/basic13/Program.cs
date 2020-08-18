using System;
using System.Collections.Generic;
using System.Linq;

namespace basic13
{
    public class Program
    {
       public static void PrintNumber()
       {
           for (int i = 1; i <= 255; i++){
               System.Console.WriteLine(i);
           }
       }

       public static void PrintOdds()
       {
           for (int i = 1; i <=255; i= i + 2){
               System.Console.WriteLine(i);
           }
       }

       public static void PrintSum()
       {
           int sum = 0;
           for (int i = 1; i <= 255; i++)
           {
               sum += i;
               System.Console.WriteLine(i + " Sum: "+ sum);
           }
       }

       public static void LoopArray(int[] numbers)
       {
           foreach (int i in numbers){
               System.Console.WriteLine(i);
           }
       }

       public static int FindMax(int[] numbers)
       {
           int m = numbers.Max();
           return m;
       }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            int avg = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
                avg = sum / numbers.Length;
                System.Console.WriteLine(avg);
            }
        }

        public static int[] OddArray()
        {
            int[] arr = new int[128];
            for (int i = 0; i <arr.Length; i++){
                arr[i] = i; 
            }
            return arr;  
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int counter = 0;
            for (int i = 0; i <=numbers.Length; i++){
                if(numbers[i] > y){
                    counter ++;
                }
            }
            return counter;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            
        }

        public static void Main (string[] args)
        {
            int [] numbers = {4,2,6,1,7};
            int y = 5;
            
            int greaty = GreaterThanY(numbers, y);

            System.Console.WriteLine(greaty);
        }
    }
}
