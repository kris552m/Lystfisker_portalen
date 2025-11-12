using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Profile
    {
        //Properties
        public string Username { get; set; }
        private string Password { get; set; }
        public string ProfilePicture { get; set; }
        public List<Profile> Following { get; set; }

        //Constructor
        public Profile(string username, string profilePicture, List<Profile> following)
        {
            Username = username;
            ProfilePicture = profilePicture;
            Following = following;
        }
    }
}
