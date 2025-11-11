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


        //CRUD Methods
        public void CreateLocation()
        {
            // Logic to create a new location
        }
        public void ReadLocation()
        {
            // Logic to read a location
        }
        public void UpdateLocation()
        {
            // Logic to update a location
        }
        public void DeleteLocation()
        {
            // Logic to delete a location
        }
    }
}
