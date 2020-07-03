using BeautySalonApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonApp.Services
{
    public class AppointmentService
    {
        public Appointment SetAppointmentForCustomer(DateTime date, Service service)
        {
            Appointment appointment = new Appointment();

            appointment.Date = date;
            appointment.Service = service;

            return appointment;
        }

        public void CalculateDiscountPrice(Customer customer)
        {
            if (customer.Status == Status.Normal)
            {
                customer.Appointment.Service.PriceWithDiscount = Math.Round(customer.Appointment.Service.Price - 0.1m * customer.Appointment.Service.Price);
            }
            if (customer.Status == Status.Brown)
            {
                customer.Appointment.Service.PriceWithDiscount = Math.Round(customer.Appointment.Service.Price - 0.2m * customer.Appointment.Service.Price);
            }
            if (customer.Status == Status.Silver)
            {
                customer.Appointment.Service.PriceWithDiscount = Math.Round(customer.Appointment.Service.Price - 0.3m * customer.Appointment.Service.Price);
            }
            if (customer.Status == Status.Gold)
            {
                customer.Appointment.Service.PriceWithDiscount = Math.Round(customer.Appointment.Service.Price - 0.4m * customer.Appointment.Service.Price);
            }
        }
    }
}
