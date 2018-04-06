using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Passenger : User
    {
        public Passenger(string forename, string lastname, string email, string password)
        {
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;

            Console.WriteLine(String.Format("User {0} {1} has been created.", Forename, Lastname));
        }

        public override void ViewFlight()
        {
            Console.WriteLine("Passenger can view all future flights.");
        }

        public void MakePayment(string paymentMethod, double amount)
        {
            PaymentCreator paymentCreator = new PaymentCreator(paymentMethod);
            Payment payment = paymentCreator.CreatePayment();
            payment.MakePayment(amount);
            
        }

        public void BookTicket(Flight flight, Seat seat, string paymentMethod)
        {
            MakePayment(paymentMethod, seat.SeatCharge + flight.TravelCharge);
            flight.SubscribeUpdates(this);
        }

        internal void Notify(string notification)
        {
            Console.WriteLine("Passenger got notified that: \n \t" + notification);
        }
    }
}
