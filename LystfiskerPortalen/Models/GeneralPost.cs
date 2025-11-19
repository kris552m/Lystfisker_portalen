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
        public GeneralPost(bool isQuestion, DateTime postTime, string picture, string description, Location location, List<Comment> comments, List<Reaction> reactions)
            : base(postTime, picture, description, location, comments, reactions)
        {
            IsQuestion = isQuestion;
        }



    }
}
