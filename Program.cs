// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar  = new Car();
            myCar.Make = "Mazda";
            myCar.Model = "CX5";
            myCar.Year = 2017;
            myCar.Color = "Black";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public string Color {get; set;}

    }
    
}