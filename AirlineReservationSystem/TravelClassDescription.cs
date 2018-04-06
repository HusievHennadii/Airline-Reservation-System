using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class TravelClassDescription
    {
        private TravelClass travelClass;
        private int capacity;
        private List<Seat> seatList;

        public TravelClassDescription(TravelClass travelClass, int capacity, List<Seat> seatList)
        {
            TravelClass = travelClass;
            Capacity = capacity;
            SeatList = seatList;
        }

        public TravelClass TravelClass { get => travelClass; set => travelClass = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public List<Seat> SeatList { get => seatList; set
            {
                int alreadyCreated = SeatList != null ? SeatList.Count() : 0;
                if (alreadyCreated <= Capacity) seatList = value;
                else Console.WriteLine(String.Format("This {0} class is full enough to locate seats.", travelClass));
            }
        }
    }
}
