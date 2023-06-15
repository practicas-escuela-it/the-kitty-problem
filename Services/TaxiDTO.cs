using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TaxiDTO
    {
        public TaxiDTO(Taxi taxi)
        {
            this.Name = taxi.Name;
            this.Price = taxi.Price;
        }

        public object Name { get; set; }
        public double Price { get; set; }
    }
}