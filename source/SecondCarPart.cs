using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace source
{
    public partial class SecondCarPart
    {
        private bool isRegisterd;

        public bool RegisteredCar(ref long cash)
        {
            if(! isRegisterd)
            {
                if(YearOfProduction * MulticastRegistration > cash)
                {
                    WriteLine("U dont have money");
                    ReadLine();
                    return false;
                }
                else
                {
                    cash -= (long)(YearOfProduction * MulticastRegistration);
                    WriteLine("Successful. You have a plate.");
                    ReadLine();
                    isRegisterd = true;
                    return true;
                }

            }
            else
            {
                WriteLine("CAR HAS A PLATE!");
                ReadLine();
                return false;
            }
        }
        public long GetRegistrationCost()
        {
            return (long)(YearOfProduction * MulticastRegistration);
        }
        public static int GetAmmoutOfCars()
        {
            return AmmoutOfCars;
        }
    }
}
