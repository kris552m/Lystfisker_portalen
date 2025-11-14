using System.ComponentModel.DataAnnotations;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Event : Post
    {
        //Properties
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime EventTime { get; set; }

        //Constructor
        public Event(string title, DateTime eventTime, DateTime postTime, string picture, string description, Location location, List<Comment> comments, List<Reaction> reactions)
            : base(postTime, picture, description, location, comments, reactions)
        {
            Title = title;
            EventTime = eventTime;
        }



    }
}
