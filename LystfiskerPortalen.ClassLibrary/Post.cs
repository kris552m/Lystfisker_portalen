using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LystfiskerPortalen.ClassLibrary
{
    public abstract class Post
    {
        // Properties
        public int PostId { get; set; }
        public DateTime PostTime { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Reaction> Reactions { get; set; } = new List<Reaction>();



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
    }
}

