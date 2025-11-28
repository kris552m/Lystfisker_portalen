using System.ComponentModel.DataAnnotations.Schema;

namespace LystfiskerPortalen.Models
{
    public abstract class Post
    {
        // Properties
        public int PostId { get; set; }
        public DateTime PostTime { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public string Description { get; set; } = string.Empty;
        public Location Location { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Reaction> Reactions { get; set; } = new List<Reaction>();

        [ForeignKey(nameof(Profile))]
        public string ProfileId { get; set; }
        public Profile Profile { get; set; }


        // Constructor
        public Post(DateTime postTime, string picture, string description, Location location, List<Comment> comments, List<Reaction> reactions)
        {
            PostTime = postTime;
            Picture = picture;
            Description = description;
            Location = location;
            Comments = comments;
            Reactions = reactions;
        }
        public Post()
        {

        }



        // Additional Methods
        public List<Reaction> GetAllReactions()
        {
            return Reactions;
        }
        public List<Comment> GetAllComments()
        {
            return Comments;
        }



    }
}

