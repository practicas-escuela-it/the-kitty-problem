﻿using Model;

namespace Controller.Models
{
    public class TaxiFound
    {
        public TaxiFound()
        {

        }

        public TaxiFound(Taxi taxi)
        {
            this.Id = taxi.Id;
            this.Name = taxi.Name;
            this.Price = taxi.Price;
            this.AcceptCat = taxi.AcceptCat;
            this.IsPremium = taxi.IsPremium;
        }
        
        public int Id { get; private set; }
        public object Name { get; set; }
        public double Price { get; set; }
        public bool AcceptCat { get; set; }
        public bool IsPremium { get; set; }
    }
}