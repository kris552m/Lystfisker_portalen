using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    internal class Reaction
    {
        //Propperties
        public string Icon { get; set; }
        public Profile Profile { get; set; }

        //Constructor
        public Reaction(string icon, Profile profile)
        {
            Icon = icon;
            Profile = profile;
        }

        //CRUD Methods
        public void CreateReaction()
        {
            // Logic to create a new reaction
        }
        public void ReadReaction()
        {
            // Logic to read a reaction
        }
        public void UpdateReaction()
        {
            // Logic to update a reaction
        }
        public void DeleteReaction()
        {
            // Logic to delete a reaction
        }
    }
}
