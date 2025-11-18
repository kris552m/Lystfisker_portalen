using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.ClassLibrary
{
    public class Event : Post
    {
        //Properties
        public string Title { get; set; }
        public DateTime EventTime { get; set; }

        //Constructor
        public Event(string title, DateTime eventTime, DateTime postTime, string picture, string description, Location location, List<Comment> comments, List<Reaction> reactions)
            : base(postTime, picture, description, location, comments, reactions)
        {
            Title = title;
            EventTime = eventTime;
        }
        public Event()
        {

        }



    }
}
