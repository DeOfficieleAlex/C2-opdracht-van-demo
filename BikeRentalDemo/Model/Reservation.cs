﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BikeRentalDemo.Model
{
    public class Reservation
    {
        public int ID { get; set; }
        public int CustomerID  {get; set;}
        public virtual Customer Customer { get; set; }
        public int BikeID {get;set;}
        public virtual Bike Bike { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Store PickUp { get; set; }
        public virtual Store DropOff { get; set; }
        public double TotalPrice { get; set; }
    }
}
