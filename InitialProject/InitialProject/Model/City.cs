﻿using InitialProject.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Model
{
    public class City : ISerializable
    {   
        
        public string Name { get; set; }
        public string Country { get; set; }
        public int CityId { get; set; }
        public City() { }
        public void FromCSV(string[] values)
        {
            CityId = int.Parse(values[0]);
            Name = values[1];
            Country = values[2];
        }

        public string[] ToCSV()
        {
            string[] csvValues =
            {
                CityId.ToString(), Name, Country
            };
            return csvValues;
        }
    }
}
