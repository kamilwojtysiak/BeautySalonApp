using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonApp.Domain
{
    public class Customer
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Status Status { get; set; }

        public Appointment Appointment { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \nStatus: {Status} \nPhone number: {PhoneNumber} \nAPPOINTMENT INFO {Appointment}";
        }
    }
}
