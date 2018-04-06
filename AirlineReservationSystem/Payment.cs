using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public interface Payment
    {
        void MakePayment(double amount);
    }

    public abstract class CardPayment : Payment
    {
        public abstract void MakePayment(double amount);
    }

    public class CreditCard: CardPayment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine("Payment done through Credit Card");
        }
    }

    public class DebitCard : CardPayment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine("Payment done through Debit Card");
        }
    }

    public class NetBanking : Payment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine("Payment done through Net Banking");
        }
    }

    public class PaymentCreator
    {
        private string paymentMethod;

        public PaymentCreator(string paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }

        public Payment CreatePayment()
        {
            if(PaymentMethod == "Credit Card") return new CreditCard();
            if (PaymentMethod == "Debit Card") return new DebitCard();
            else return new NetBanking();
        }
    }
}
