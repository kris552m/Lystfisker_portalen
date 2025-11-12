using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    public class Location
    {
        //Properties
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        //Constructor
        public Location(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }


       
    }
}
