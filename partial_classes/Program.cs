using source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace partial_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SOLID_SIZE = 5;
            FirstCarPart[] carsSolid = new FirstCarPart[SOLID_SIZE] { new FirstCarPart("Chevrolet", 2013, true, 4.0, 29000) };
            foreach(FirstCarPart m in carsSolid)
            {
                m.Show();
                WriteLine();
            }
            WriteLine("AmmoutOfCar: ");
            WriteLine(FirstCarPart.GetAmmoutOfCars());
            ReadLine();
        }
    }
}
