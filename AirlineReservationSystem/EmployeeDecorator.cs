using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public abstract class EmployeeDecorator : Employee
    {
        private Employee employee;

        public EmployeeDecorator(Employee employee)
        {
            this.Employee = employee;
        }

        public Employee Employee { get => employee; set => employee = value; }

        public abstract void UpdateFlight(Flight flight, DateTime newDepartureTime);
    }

    public class EmployeePrivilegeDecorator : EmployeeDecorator
    {
        public EmployeePrivilegeDecorator(Employee employee) : base(employee)
        {
        }

        public override void UpdateFlight(Flight flight, DateTime newDepartureTime)
        {
            Console.WriteLine("{0} {1} has updated flight.", Employee.Forename, Employee.Lastname);
            flight.DepartureTime = newDepartureTime;
        }
    }
}
