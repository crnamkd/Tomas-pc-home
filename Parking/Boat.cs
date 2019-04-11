using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Boat
    {
        public string Name { get; set; }
        public bool BesPlatno { get; set; }


        public bool IsParked
        {
            get
            {
                return Parking != null;
            }
        }
        public Parking Parking { get; set; }

        public void LeaveParking()
        {
            Parking.LeaveBoat(this);
        }
    }
}
