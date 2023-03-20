﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xaml.Schema;
using System.Xml.Linq;
using InitialProject.Serializer;
using InitialProject.Model;

namespace InitialProject.Model
{
    public enum GuideLanguage
    {
        All,
        Serbian,
        English
    }
    public class Tour : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public string Description { get; set; }
        public GuideLanguage Language { get; set; }

        public int MaximumGuests { get; set; }
        
        public DateTime Start { get; set; }
        public int Duration { get; set; }
        public string PictureURL { get; set; }
        public int CurrentNumberOfGuests { get; set; }
        public Tour() 
        {
            Name = string.Empty;
            Location = new Location();
            Description = string.Empty;
            PictureURL = string.Empty;
        }

        public Tour(int id, string name, int locationId, string description, GuideLanguage language, int maximumGuests, DateTime start, int duration, string pictureURL, int currentNumberOfGuests)
        {
            Id = id;
            Name = name;
            LocationId = locationId;
            Description = description;
            Language = language;
            MaximumGuests = maximumGuests;
            Start = start;
            Duration = duration;
            PictureURL = pictureURL;
            CurrentNumberOfGuests = currentNumberOfGuests;
        }

        public void FromCSV(string[] values)
        {
            Id = Convert.ToInt32(values[0]);
            Name = values[1];
            LocationId = Convert.ToInt32(values[2]);
            Description = values[3];
            Language = (GuideLanguage)Enum.Parse(typeof(GuideLanguage), values[4]);
            MaximumGuests = Convert.ToInt32(values[5]);
            Start = DateTime.Parse(values[6]);
            Duration = Convert.ToInt32(values[7]);
            PictureURL = values[8];
            // maybe change the name of field to NumberOfGuests
            CurrentNumberOfGuests = Convert.ToInt32(values[9]);
        }
        public string[] ToCSV()
        {
            string[] csvValues =
            {
                Id.ToString(),
                Name,
                LocationId.ToString(),
                Description,
                Language.ToString(),
                MaximumGuests.ToString(),
                Start.ToString(), 
                Duration.ToString(),  
                PictureURL.ToString(),
                CurrentNumberOfGuests.ToString()
            };
            return csvValues;
        }
    }
}
