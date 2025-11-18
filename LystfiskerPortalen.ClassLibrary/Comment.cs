using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Comment
    {
        // Properties
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime CommentTime { get; set; }
        public List<Reaction> Reactions { get; set; } = new List<Reaction>();

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }

        // Constructor
        public Comment(string text, DateTime commentTime, List<Reaction> reactions, Profile profile)
        {
            Text = text;
            CommentTime = commentTime;
            Reactions = reactions;
            Profile = profile;
        }
        public Comment()
        {

        }
    }
}
