namespace LystfiskerPortalen.ClassLibrary
{
    public abstract class Post
    {
        // Properties
        public int Id { get; set; }
        public DateTime PostTime { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Reaction> Reactions { get; set; }



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
    }
}

