using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class TravelClass
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public TravelClass(string name)
        {
            Name = name;
        }
    }
}
