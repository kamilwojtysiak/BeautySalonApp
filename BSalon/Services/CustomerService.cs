using BeautySalonApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonApp.Services
{
    public class CustomerService
    {
        public Customer AddCustomer(string name, string phoneNumber, Status status, Appointment appointment)
        {
            Customer customer = new Customer();

            customer.Name = name;
            customer.PhoneNumber = phoneNumber;
            customer.Status = status;
            customer.Appointment = appointment;

            return customer;
        }
    }
}