using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4a_parking.models
{
    class CarPark
    {
        public List<Customer> listofCustomers = new List<Customer>();

        public CarParkCharge carparkCharge = new CarParkCharge();
        public CarPark()
        {

        }
        
        public override string ToString()
        {
            return "I am the CarPark";
        }
        public void AddCustomer(Customer newCustomer)
        {
            listofCustomers.Add(newCustomer);
        }
        public void CalculateCharges()
        {
            foreach(Customer customer in listofCustomers)
            {
                int calculatedCharge = carparkCharge.CalculateCharges(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer: cost is {calculatedCharge} for registration {customer.registration}");
            }
        }
    }
}
