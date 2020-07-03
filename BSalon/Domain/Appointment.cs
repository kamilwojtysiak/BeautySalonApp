using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonApp.Domain
{
    public class Appointment
    {
        public DateTime Date { get; set; }

        public Service Service { get; set; }

        public override string ToString()
        {
            return $"\nDate: {Date} \nService name: {Service.Name} \nPrice: {Service.Price}PLN \nPrice with discount: {Service.PriceWithDiscount} \n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
}
