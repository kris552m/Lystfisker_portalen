using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LystfiskerPortalen.Frontend.Models
{
    public class Catch : Post
    {
        //Properties
        public DateTime CatchTime { get; set; }
        public string Lure { get; set; }
        public string Technique { get; set; }
        public Fish Fish { get; set; }


        //Constructor
        public Catch(DateTime catchTime, string lure, string technique, Fish fish, DateTime postTime, string picture, string description, Location location, List<Comment> comments, List<Reaction> reactions)
            : base(postTime, picture, description, location, comments, reactions)
        {
            CatchTime = catchTime;
            Lure = lure;
            Technique = technique;
            Fish = fish;
        }

       



    }
}
