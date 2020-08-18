using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> box = new List<object>(); 
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");

            int sum =0;
            foreach(object item in box)
            {
                if (item is int){
                    System.Console.WriteLine(item + " It is int");
                    sum+= (int)item;
                    System.Console.WriteLine($"The sum is: {sum}");
                }
                if (item is string){
                    System.Console.WriteLine(item + " It is String");
                }
                if (item is bool){
                    System.Console.WriteLine(item + " It is Boolean");
                }
            }
        }
    }
}
