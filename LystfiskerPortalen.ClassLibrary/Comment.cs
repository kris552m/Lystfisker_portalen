using System.ComponentModel.DataAnnotations;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Comment
    {
        // Properties
        [Required]
        public string Text { get; set; }
        public DateTime CommentTime { get; set; }
        public List<Reaction> Reactions { get; set; }
        public Profile Profile { get; set; }
        public Post Post { get; set; }

        // Constructor
        public Comment(string text, DateTime commentTime, List<Reaction> reactions, Profile profile)
        {
            Text = text;
            CommentTime = commentTime;
            Reactions = reactions;
            Profile = profile;
        }
    }
}
