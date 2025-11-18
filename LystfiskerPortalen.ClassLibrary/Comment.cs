using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    public class Comment
    {
        // Properties
        public string Text { get; set; }
        public DateTime CommentTime { get; set; }
        public List<Reaction> Reactions { get; set; }
        public Profile Profile { get; set; }

        // Constructor
        public Comment(string text, DateTime commentTime, List<Reaction> reactions, Profile profile)
        {
            Text = text;
            CommentTime = commentTime;
            Reactions = reactions;
            Profile = profile;
        }



        // Additional Methods
        public List<Reaction> GetAllReactions()
        {
            return Reactions;
        }
    }
}
