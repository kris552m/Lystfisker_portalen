using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    internal class Fish
    {
        //Properties
        public string Name { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }

        //Constructor
        public Fish(string name, int length, double weight)
        {
            Name = name;
            Length = length;
            Weight = weight;
        }


        //CRUD Methods
        public void CreateFish()
        {
            // Logic to create a new fish
        }
        public void ReadFish()
        {
            // Logic to read a fish
        }
        public void UpdateFish()
        {
            // Logic to update a fish
        }
        public void DeleteFish()
        {
            // Logic to delete a fish
        }

    }
}
