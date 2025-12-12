using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LystfiskerPortalen.Models
{
    public class Catch : Post
    {
        //Properties

        public DateTime CatchTime { get; set; }
        public string Lure { get; set; } = string.Empty;
        public string Technique { get; set; } = string.Empty;

        [ForeignKey(nameof(Fish))]
        public int FishId { get; set; }
        public Fish Fish { get; set; }


        //Constructor
        public Catch(DateTime catchTime, string lure, string technique, Fish fish, DateTime postTime, List<Picture> pictures, string description, Location location, List<Comment> comments, List<Reaction> reactions)
            : base(postTime, pictures, description, location, comments, reactions)
        {
            CatchTime = catchTime;
            Lure = lure;
            Technique = technique;
            Fish = fish;
        }
        public Catch()
        {
            
        }
        
    }
}
