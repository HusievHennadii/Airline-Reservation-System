using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Brand
    {
        private string name;
        private List<Plane> listPlane;

        public string Name { get => name; set => name = value; }
        public List<Plane> ListPlane { get => listPlane; set => listPlane = value; }

        public Brand(string name)
        {
            Name = name;
            ListPlane = new List<Plane>();
            Console.WriteLine(String.Format("{0} has been initiated.", Name));
        }

        public void RegisterPlane(Plane plane)
        {
            ListPlane.Add(plane);
            Console.WriteLine("Plane {0} {1} has been registered into {2}", plane.Manufacturer, plane.Model, Name);
        }
    }
}
