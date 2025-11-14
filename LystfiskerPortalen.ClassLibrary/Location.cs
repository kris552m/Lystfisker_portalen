using System.ComponentModel.DataAnnotations;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Location
    {
        //Properties
        [Required]
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Post> Posts { get; set; }


        //Constructor
        public Location(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }



    }
}
