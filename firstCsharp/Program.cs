using System;

namespace firstCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 1; i <=255; i ++)
            // {
            //     System.Console.WriteLine(i);
            // }

            for(int j = 1; j <=100; j ++)
            {
                if(j % 3 == 0 && j % 5 == 0)
                {
                    System.Console.WriteLine(" ");
                }
                else if (j % 3 == 0 || j % 5 == 0)
                {
                    System.Console.WriteLine(j);
                }
            }

            // for (int i = 1; i <= 100; i++)  
            // {  
            //     if (i % 3 == 0 && i % 5 == 0)  
            //     {  
            //         Console.WriteLine("FizzBuzz");  
            //     }  
            //     else if (i % 3 == 0)  
            //     {  
            //     Console.WriteLine("Fizz");  
            //     }  
            //     else if (i % 5 == 0)  
            //     {  
            //     Console.WriteLine("Buzz");  
            //     }  
            //     else  
            //     {  
            //         Console.WriteLine(i);  
            //     }  
            // }  
        }
    }
}
