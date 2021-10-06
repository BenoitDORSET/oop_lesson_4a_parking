using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4a_parking.models
{
    class Customer
    {
        public int hoursParked { get; set; }
        public string registration { get; set; }

        public Customer(int _hoursParked, string _registration)
        {
            hoursParked = _hoursParked;
            registration = _registration;
        }
        public override string ToString()
        {
            return "I am the Customer()";
        }
    }
}
