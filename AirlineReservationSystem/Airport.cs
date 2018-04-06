using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Airport
    {
        private string name, ataCode;

        public Airport(string name, string ataCode)
        {
            Name = name;
            AtaCode = ataCode;
        }

        public string Name { get => name; set => name = value; }
        public string AtaCode { get => ataCode; set => ataCode = value; }

        
    }
}
