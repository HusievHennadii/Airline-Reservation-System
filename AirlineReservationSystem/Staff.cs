using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    /// <summary>
    /// Class staff
    /// </summary>
    public class Staff: Employee
    {
        /// <summary>
        /// Staff Constructor
        /// </summary>
        /// <param name="forename"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Staff(string forename, string lastname, string email, string password)
        {
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;

            Console.WriteLine(String.Format("User {0} {1} has been created.", Forename, Lastname));
        }

        /// <summary>
        /// View Flight
        /// </summary>
        public override void ViewFlight()
        {
            Console.WriteLine("Staff can view all future & past flights.");
        }

        /// <summary>
        /// To register plane
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="model"></param>
        /// <param name="travelClasses"></param>
        /// <param name="brand"></param>
        public void RegisterPlane(string manufacturer, string model, List<TravelClassDescription> travelClasses, Brand brand) {
            brand.RegisterPlane(new Plane(manufacturer, model, travelClasses));
        }

        /// <summary>
        /// To Schedule flight
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="route"></param>
        /// <param name="departureTime"></param>
        /// <param name="arrivalTime"></param>
        /// <param name="travelCharge"></param>
        /// <returns></returns>
        public Flight ScheduleFlight(Plane plane, Route route, DateTime departureTime, DateTime arrivalTime, double travelCharge)
        {
            return new Flight(plane, route, departureTime, arrivalTime, travelCharge);
        }
    }

    class Admin : Employee
    {
        Admin(string forename, string lastname, string email, string password)
        {
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;
            Console.WriteLine(String.Format("User {0} {1} has been created.", Forename, Lastname));
        }

        public override void ViewFlight()
        {
            Console.WriteLine("Admin can view all future & past flights.");
        }
    }

    public class Pilot : Employee
{
        public Pilot(string forename, string lastname, string email, string password)
        {
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;
            Console.WriteLine(String.Format("User {0} {1} has been created.", Forename, Lastname));
        }
        public override void ViewFlight()
        {
            Console.WriteLine("Pilot can view all assigned flights.");
        }
    }
}
