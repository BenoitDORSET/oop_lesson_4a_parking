using System;
using oop_lesson_4a_parking.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4a_parking.test
{
    class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }
        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listofCustomers.Add(new Customer(1, "a"));
            carpark.listofCustomers.Add(new Customer(2, "b"));
            carpark.listofCustomers.Add(new Customer(3, "c"));
            carpark.listofCustomers.Add(new Customer(4, "d"));
            carpark.listofCustomers.Add(new Customer(5, "e"));

            carpark.CalculateCharges();

            Customer customer = new Customer(0, "f");
            CarParkCharge carparkcharge = new CarParkCharge();

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());


        }

    }
}
