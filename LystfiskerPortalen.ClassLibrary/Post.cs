using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RazorClassLibrary
{
    internal class Post
    {
        // Properties
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


        // CRUD Methods
        public void CreatePost()
        {
            // Logic to create a new post
        }
        public void ReadPost()
        {
            // Logic to read a post
        }
        public void UpdatePost()
        {
            // Logic to update a post
        }
        public void DeletePost()
        {
            // Logic to delete a post
        }

        // Additional Methods
        public Reaction[] GetAllReactions()
        {
            // Logic to get all reactions for the post
        }
        public Reaction[] GetAllComments()
        {
            // Logic to get all comments for the post
        }



    }
}

