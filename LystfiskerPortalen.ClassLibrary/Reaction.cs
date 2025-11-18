namespace LystfiskerPortalen.ClassLibrary
{
    public class Reaction
    {
        //Propperties
        public string Icon { get; set; }
        public Profile Profile { get; set; }
        public List<Comment> Comments { get; set; }
        public Post Post { get; set; }

        //Constructor
        public Reaction(string icon, Profile profile)
        {
            Icon = icon;
            Profile = profile;
        }


    }
}
