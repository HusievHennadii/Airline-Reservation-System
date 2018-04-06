using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    class Airline
    {
        private string name;
        private static Airline instance;
        private List<Brand> listBrand;
        public string Name { get => name; set => name = value; }
        public List<Brand> ListBrand { get => listBrand; set => listBrand = value; }
        public static Airline Instance { get {
                if (instance == null) instance = new Airline("Air Canada");
                return instance;
            } set => instance = value; }

        private Airline(string name)
        {

            Name = name;
            ListBrand = new List<Brand>();
            Console.WriteLine(String.Format(@"""{0}"" Airline has been created.", Name));
        }
    }
}
