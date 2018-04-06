using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Route
    {
        private Airport origin, destinaton;

        public Route(Airport origin, Airport destinaton)
        {
            Origin = origin;
            Destinaton = destinaton;
        }

        public Airport Origin { get => origin; set => origin = value; }
        public Airport Destinaton { get => destinaton; set => destinaton = value; }
    }
}
