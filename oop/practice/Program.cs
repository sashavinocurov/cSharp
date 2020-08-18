using System;

namespace practice
{
    public class Vehicle 
    {
        public int NumPassengers;
        public string Color;
        public double MaxSpeed;

        public void MakeNoise(string noise)
        {
            System.Console.WriteLine(noise);
        }
        public void MakeNoise()
        {
            System.Console.WriteLine("BEEP!");
        }
        
        public string ColorProp
        {
            get{
                return $"This thin is {Color}";
            }
            set{
                Color = value;
            }
        }
        public Vehicle()
        {
            NumPassengers = 6;
        }

        public string Name {get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people");
        }
    }
}
