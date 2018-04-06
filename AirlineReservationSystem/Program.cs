using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline airline = Airline.Instance;
            airline.ListBrand.Add(new Brand("Air Canada Express"));
            airline.ListBrand.Add(new Brand("Air Canada Rouge"));
            airline.ListBrand.Add(new Brand("Air Canada"));

            TravelClass Bussiness = new TravelClass("Bussiness");
            TravelClass PremiumEconomy = new TravelClass("Premium Economy");
            TravelClass Economy = new TravelClass("Economy");

            List<Seat> BussinessSeats = new List<Seat>();
            for(int i=0; i<50; i++) {
                BussinessSeats.Add(new Seat(i.ToString(),Bussiness, 1500.14));
            }

            List<Seat> PEcoSeats = new List<Seat>();
            for (int i = 0; i < 50; i++)
            {
                PEcoSeats.Add(new Seat(i.ToString(), PremiumEconomy, 1000.14));
            }

            List<Seat> EcoSeats = new List<Seat>();
            for (int i = 0; i < 50; i++)
            {
                EcoSeats.Add(new Seat(i.ToString(), Economy, 801.95));
            }

            List<TravelClassDescription> travelClasses = new List<TravelClassDescription>();
            travelClasses.Add(new TravelClassDescription(Bussiness, BussinessSeats.Count(), BussinessSeats));
            travelClasses.Add(new TravelClassDescription(PremiumEconomy, PEcoSeats.Count(), PEcoSeats));
            travelClasses.Add(new TravelClassDescription(Economy, EcoSeats.Count(), EcoSeats));

            Staff staffMember1 = new Staff("Staff", "Member", "staff.member@aircanada.ca", "password");
            staffMember1.RegisterPlane("Boieng", "777", travelClasses, airline.ListBrand.First());

            Airport Toronto = new Airport("Toronto", "YYZ");
            Airport Vancouver = new Airport("Vancouver", "YVR");
            Route route1 = new Route(Toronto, Vancouver);
            Plane plane1 = airline.ListBrand.First().ListPlane.First();
            Flight flight1 = staffMember1.ScheduleFlight(plane1, route1, new DateTime(2018,1,15,5,35,0), new DateTime(2018, 1, 15, 10, 48, 0), 200);

            Passenger passenger1 = new Passenger("Passenger", "User", "passenger@gmail.ca", "secret");
            passenger1.ViewFlight();
            staffMember1.ViewFlight();
            Seat seat1 = flight1.Plane.TravelClassDescription.First().SeatList.First();
            passenger1.BookTicket(flight1,seat1, "Credit Card");

            Employee pilot = new Pilot("Pilot", "User", "employee@aircanada.ca", "pilotsecret");
            EmployeePrivilegeDecorator employeePrivilegeDecorator = new EmployeePrivilegeDecorator(pilot);
            employeePrivilegeDecorator.UpdateFlight(flight1, new DateTime(2018, 1, 15, 5, 40, 0)); 

            Console.ReadKey();
        }
    }
}
