using System;

namespace multTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a <=10; a++);
            for(int b = 2; b <=20; b = b +2);
            for(int c = 3; c <=30; c = c +3);
            for(int d = 4; d <=40; d = d +4);
            for(int e = 5; e <=50; e = e +5);
            for(int f = 6; f <=60; f = f +6);
            for(int g = 7; g <=70; g = g +7);
            for(int h = 8; h <=80; h = h +8);
            for(int i = 9; i <=90; i = i +9);
            for(int j = 10; j <=100; j = j +10);
            int [,] array2D = new int[10,10]{ {a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i}, {j}};

            System.Console.WriteLine();
        }
    }
}
