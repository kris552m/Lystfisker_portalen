using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Profile : IdentityUser
    {
        //Properties
        public string ProfilePicture { get; set; }
        public List<Profile> Following { get; set; } = new List<Profile>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Reaction> Reactions { get; set; } = new List<Reaction>();

        //Constructor
        public Profile(string profilePicture, List<Profile> following)
        {
            ProfilePicture = profilePicture;
            Following = following;
        }
        public Profile()
        {

        }
    }
}
