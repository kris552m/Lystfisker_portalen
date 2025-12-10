using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LystfiskerPortalen.Models
{
    public class Profile : IdentityUser
    {
        //Properties
        
        public string ProfilePicture { get; set; } = string.Empty;
        public List<Profile> Following { get; set; } = new List<Profile>();
        public int FollowingCount { get { return Following?.Count ?? 0; } }
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Reaction> Reactions { get; set; } = new List<Reaction>();
        public List<Profile> Followers { get; set; }
        public int FollowersCount {get { return Followers != null ? Followers.Count : 0;} }


        //Constructor
        public Profile(string profilePicture, List<Profile> following)
        {
            ProfilePicture = profilePicture;
            Following = following;
        }
        public Profile()
        {
            
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
