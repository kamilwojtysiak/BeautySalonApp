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
        public Appointment CreateAppointment(DateTime date, Service service)
        {
            Appointment appointment = new Appointment();

            appointment.Date = date;
            appointment.Service = service;

            return appointment;
        }

        public void CalculateDiscountPrice(Customer customer)
        {
           
        }
    }
}
