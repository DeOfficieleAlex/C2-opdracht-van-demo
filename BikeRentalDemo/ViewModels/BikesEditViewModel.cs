﻿using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;
using BikeRentalDemo.Model;
using BikeRentalDemo.Classes;
using BikeRentalDemo.ViewModels;


namespace BikeRentalDemo.ViewModels
{
    class BikesEditViewModel
    {
        private BikeRentalDBModel Db;
        public ObservableCollection<Bike> Bikes { get; set; }
        public RelayCommand SaveClick { get; set; }

        public BikesEditViewModel(BikeRentalDBModel db,ObservableCollection<Bike> bikes)
        {
            Db = db;
            Bikes = bikes;
            SaveClick = new RelayCommand(x => db.SaveChanges());
        }
    }
}
