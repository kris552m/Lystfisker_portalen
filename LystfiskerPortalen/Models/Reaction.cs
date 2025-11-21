using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.Models
{
    public class Reaction
    {
        //Propperties
        public int ReactionId { get; set; }
        public string Icon { get; set; }
        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }

        //Constructor
        public Reaction(string icon, Profile profile)
        {
            Icon = icon;
            Profile = profile;
        }
        public Reaction()
        {
            
        }


    }
}
