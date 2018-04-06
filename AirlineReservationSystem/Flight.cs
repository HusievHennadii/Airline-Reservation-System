using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Flight
    {
        private Plane plane;
        private Route route;
        private DateTime departureTime, arrivalTime;
        private double travelCharge;
        private List<Passenger> passengers;

        public Flight(Plane plane, Route route, DateTime departureTime, DateTime arrivalTime, double travelCharge)
        {
            Passengers = new List<Passenger>();
            Plane = plane;
            Route = route;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            TravelCharge = travelCharge;
            Console.WriteLine(String.Format("{0} {1} has been scheduled and will depart at {2} from {3}({4}) airport and will reach {5}({6}) by {7}",
                Plane.Manufacturer, Plane.Model, DepartureTime.ToString(), 
                Route.Origin.Name, Route.Origin.AtaCode, Route.Destinaton.Name, 
                Route.Destinaton.AtaCode, ArrivalTime.ToString()
            ));
        }

        public Plane Plane { get => plane; set => plane = value; }
        public DateTime DepartureTime { get => departureTime; set
            {
                if (departureTime.CompareTo(value) < 0)
                {
                    Console.WriteLine("Flight {0} {1} has been delayed.", Plane.Manufacturer, Plane.Model);
                    NotifyAllPassenger(value);
                }
                departureTime = value;
            }
        }

        private void NotifyAllPassenger(DateTime value)
        {
            foreach(var passenger in Passengers)
            {
                passenger.Notify(String.Format("Your flight is late and will now depart at {0}.", value));
            }
        }

        public DateTime ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public double TravelCharge { get => travelCharge; set => travelCharge = value; }
        public Route Route { get => route; set => route = value; }
        public List<Passenger> Passengers { get => passengers; set => passengers = value; }

        public void SubscribeUpdates(Passenger passenger)
        {
            if (Passengers == null) Passengers = new List<Passenger>();
            Passengers.Add(passenger);
        }
    }
}
