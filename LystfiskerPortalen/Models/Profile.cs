using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.Models
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
            return Following;
        }
        public List<Profile> AddProfileToFollowing(Profile profile)
        {
            if (Following == null)
                Following = new List<Profile>();
            if (!Following.Contains(profile))
                Following.Add(profile);
            return Following;
        }

        public List<Profile> RemoveProfileFromFollowing(Profile profile)
        {
            if (Following != null && Following.Contains(profile))
                Following.Remove(profile);
            return Following;
        }
    }



}
