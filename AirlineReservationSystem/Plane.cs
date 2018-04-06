using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Plane
    {
        private string manufacturer;
        private string model;
        private List<TravelClassDescription> travelClassDescription;

        public Plane(string manufacturer, string model, List<TravelClassDescription> travelClassDescription) {
            Manufacturer = manufacturer;
            Model = model;
            TravelClassDescription = travelClassDescription;
            Console.WriteLine(String.Format("{0} {1} has been created.", Manufacturer, Model));
        }

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Model { get => model; set => model = value; }
        public List<TravelClassDescription> TravelClassDescription { get => travelClassDescription; set => travelClassDescription = value; }
    }
}
