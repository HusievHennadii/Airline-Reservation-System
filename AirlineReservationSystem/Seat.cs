using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Seat
    {
        private string seatNumber;
        private TravelClass travelClass;
        private double seatCharge;
        private bool isBooked;

        public Seat(string seatNumber, TravelClass travelClass, double seatCharge)
        {
            SeatNumber = travelClass.ToString().Take(1).ToString() + seatNumber;
            TravelClass = travelClass;
            SeatCharge = seatCharge;
            IsBooked = false;
        }

        public string SeatNumber { get => seatNumber; set => seatNumber = value; }
        public TravelClass TravelClass { get => travelClass; set => travelClass = value; }
        public double SeatCharge { get => seatCharge; set => seatCharge = value; }
        public bool IsBooked { get => isBooked; set => isBooked = value; }
    }
}
