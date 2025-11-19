using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.Models
{
    public class Fish
    {
        //Properties
        public int FishId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Length { get; set; }
        public double Weight { get; set; }

        //Constructor
        public Fish(string name, int length, double weight)
        {
            Name = name;
            Length = length;
            Weight = weight;
        }
        public Fish()
        {
            
        }




    }
}
