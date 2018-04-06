using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public abstract class User
    {
        private string forename, lastname, email, password;

        public string Forename { get => forename; set => forename = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public abstract void ViewFlight();
    }
}
