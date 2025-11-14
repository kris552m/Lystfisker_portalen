using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
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

        
        // Additional Methods
        public List<Profile> GetAllFollowing()
        {
            // Logic to get all profiles this profile is following
            
        }
        public List<Profile> AddProfileToFollowing(Profile profile)
        {
            // Logic to add a profile to the following list
           
        }

        public List<Profile> RemoveProfileFromFollowing(Profile profile)
        {
            // Logic to remove a profile from the following list

        }


    }
}
