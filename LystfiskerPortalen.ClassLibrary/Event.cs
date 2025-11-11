using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    public class Event
    {
        //Properties
        public string Title { get; set; }
        public DateTime EventTime { get; set; }

        //Constructor
        public Event(string title, DateTime eventTime)
        {
            Title = title;
            EventTime = eventTime;
        }

        //CRUD Methods
        public void CreateEvent()
        {
            // Logic to create a new event
        }
        public void ReadEvent()
        {
            // Logic to read an event
        }
        public void UpdateEvent()
        {
            // Logic to update an event
        }
        public void DeleteEvent()
        {
            // Logic to delete an event
        }


    }
}
