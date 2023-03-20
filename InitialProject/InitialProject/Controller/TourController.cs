﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialProject.Model;
using InitialProject.Model.DAO;

namespace InitialProject.Controller
{
    public class TourController
    {
        private readonly TourDAO _tourDAO;

        public TourController()
        {
            _tourDAO = new TourDAO();
        }

        public List<Tour> GetAll()
        {
            return _tourDAO.GetAll();
        }
        public Tour CreateTour(string Name, Location Location, string Description, GuideLanguage Language, int MaximumGuests, DateTime Start,int Duration, string PictureUrl) 
        {
            Tour Tour = new Tour();
            Tour.Name = Name;
            Tour.Location = Location;
            Tour.LocationId = Location.Id;
            Tour.Description = Description;
            Tour.Language = Language;
            Tour.MaximumGuests = MaximumGuests;
            Tour.Start = Start;
            Tour.Duration = Duration;
            Tour.PictureURL = PictureUrl;
            Tour.CurrentNumberOfGuests = 0;
            return _tourDAO.Save(Tour);
        }

        public List<Tour> GetFiltered(string country, string city, int duration, GuideLanguage language, int NumberOfGuests)
        {
            return _tourDAO.GetFiltered(country, city, duration, language, NumberOfGuests);
        }
    }
}
