using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    internal class Comment
    {
        // Properties
        public string Text { get; set; }
        public DateTime CommentTime { get; set; }
        public List<Reaction> Reactions { get; set; }
        public Profile Profile { get; set; }

        // Constructor
        public Comment(string text, DateTime commentTime, List<Reaction> reactions, Profile profile)
        {
            Text = text;
            CommentTime = commentTime;
            Reactions = reactions;
            Profile = profile;
        }


        // CRUD Methods
        public void CreateComment()
        {
            // Logic to create a new comment
        }
        public void ReadComment()
        {
            // Logic to read a comment
        }
        public void UpdateComment()
        {
            // Logic to update a comment
        }
        public void DeleteComment()
        {
            // Logic to delete a comment
        }


        // Additional Methods
        public Reaction[] GetAllReactions()
        {
            // Logic to get all reactions for the comment
        }
    }
}
