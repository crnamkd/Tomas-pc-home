using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking poc = new Parking(100);
            Car astra = new Car
            {
                Make = "Opel",
                Model = "Astra"
            };

            Boat yamaha = new Boat
            {
                Name = "YamahaBoat",
                BesPlatno = true,

            };

            poc.ParkVehicle(astra);
            Console.WriteLine(astra.Make + " " + astra.Model + " parked :" + astra.IsParked);
            astra.LeaveParking();
            Console.WriteLine(astra.Make + " " + astra.Model + " parked :" + astra.IsParked);
            poc.ParkBoat(yamaha);
            Console.WriteLine(yamaha.Name + " " + " ima li platno :" + yamaha.BesPlatno + "\nparked :" + yamaha.IsParked);
            yamaha.LeaveParking();
            Console.WriteLine(yamaha.Name + " " + " ima li platno :" + yamaha.BesPlatno + "\nparked :" + yamaha.IsParked);

        }
    }
}
