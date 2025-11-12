using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Reaction
    {
        //Propperties
        public string Icon { get; set; }
        public Profile Profile { get; set; }

        public List<Comment> Comments { get; set; }

        //Constructor
        public Reaction(string icon, Profile profile)
        {
            Icon = icon;
            Profile = profile;
        }


    }
}
