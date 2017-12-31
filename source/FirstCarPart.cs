using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace source
{
    public partial class FirstCarPart
    {
        public static int GetAmmoutOfCars { get; set; }
        private string Brand { get; set; }
        private int YearOfProduction { get; set; }
        private bool isRegisterd { get; set; }
        private double ScopeOfFuel { get; set; }
        private long Cost { get; set; }
        private static double MulticastRegistration { get; set; }
        static FirstCarPart()
        {
            GetAmmoutOfCars = 0;
            MulticastRegistration = 1.7;
        }
        public FirstCarPart()
        {
            Brand = "Chevrolet";
            YearOfProduction = 2013;
            isRegisterd = false;
            ScopeOfFuel = 60.0;
            Cost = 29900;
            GetAmmoutOfCars++;
        }
        public FirstCarPart(string brand)
        {
            brand = Brand;
            GetAmmoutOfCars++;
        }
        public FirstCarPart(string brand, int year)
        {
            brand = Brand;
            year = YearOfProduction;
            GetAmmoutOfCars++;
        }
        public FirstCarPart(string brand, int year, bool isRegistered)
        {
            brand = Brand;
            year = YearOfProduction;
            isRegisterd = isRegisterd;
            GetAmmoutOfCars++;
        }
        public FirstCarPart(string brand, int year, bool isRegisered, double scopeOfFuel)
        {
            brand = Brand;
            year = YearOfProduction;
            isRegisered = isRegisered;
            scopeOfFuel = ScopeOfFuel;
            GetAmmoutOfCars++;
        }
        public FirstCarPart(string brand, int year, bool isRegistered, double scopeOfFuel, long cost)
        {
            brand = Brand;
            year = YearOfProduction;
            isRegisterd = isRegisterd;
            scopeOfFuel = ScopeOfFuel;
            cost = Cost;
            GetAmmoutOfCars++;
        }
        public FirstCarPart(string brand, int year, bool isRegisterd, double scopeOfFuel, long cost, double multicastRegistration)
        {
            brand = Brand;
            year = YearOfProduction;
            isRegisterd = isRegisterd;
            cost = Cost;
            multicastRegistration = MulticastRegistration;
        }
        public void Watch()
        {
            Write("BrandOfCar:");
            WriteLine(Brand);
            Write("Year of production:");
            WriteLine(YearOfProduction);
            if(isRegisterd)
            {
                WriteLine("Car has a plate.");
            }
            else
            {
                WriteLine("Car has not a plate");
            }
            Write("Scope of fuel:");
            WriteLine(ScopeOfFuel);
            Write("Car price is");
            WriteLine(Cost);

        }
    }
}
