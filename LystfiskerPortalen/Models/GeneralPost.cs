using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Models
{
    public class GeneralPost : Post
    {

        //Propperties
        public bool IsQuestion { get; set; }


        //Constructor
        public GeneralPost(bool isQuestion, DateTime postTime, List<Picture> pictures, string description, Location location, List<Comment> comments, List<Reaction> reactions)
            : base(postTime, pictures, description, location, comments, reactions)
        {
            IsQuestion = isQuestion;
        }
        public GeneralPost()
        {
            
        }



    }
}
