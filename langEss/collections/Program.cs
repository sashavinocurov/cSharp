using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
          int [] numArray = {0,1,2,3,4,5,6,7,8,9};
          string []  nameArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
          bool [] boolArray = new bool[10];
          boolArray[0] = true;
          boolArray[1] = false;
          boolArray[2] = true;
          boolArray[3] = false;
          boolArray[4] = true;
          boolArray[5] = false;
          boolArray[6] = true;
          boolArray[7] = false;
          boolArray[8] = true;
          boolArray[9] = false;

          Random rand = new Random();
          List <string> icecream = new List<string>();
          icecream.Add("Chocolate");
          icecream.Add("Caramel");
          icecream.Add("Strawberry");
          icecream.Add("Coffee");
          icecream.Add("Mango");
        //   System.Console.WriteLine(icecream.Count);
        //   System.Console.WriteLine(icecream[2]);
          icecream.RemoveAt(2);
        //   System.Console.WriteLine(icecream[2]);
        //   System.Console.WriteLine(icecream.Count);



          Dictionary<string,string> prof = new Dictionary<string, string>();
          prof.Add(nameArray[0], icecream[rand.Next(0,3)]);
          prof.Add(nameArray[1], icecream[rand.Next(0,3)]);
          prof.Add(nameArray[2], icecream[rand.Next(0,3)]);
          prof.Add(nameArray[3], icecream[rand.Next(0,3)]);

          foreach (KeyValuePair<string,string> entry in prof)
          {
              System.Console.WriteLine(entry.Key + " " + entry.Value);
          }
        }
    }
}
