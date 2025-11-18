namespace LystfiskerPortalen.ClassLibrary
{
    public class Profile
    {
        //Properties
        public string Username { get; set; }    //bør nedarves fra user, efter Identity
        private string Password { get; set; }   //bør nedarves fra user, efter Identity
        public string ProfilePicture { get; set; }
        public List<Profile> Following { get; set; }

        //Constructor
        public Profile(string username, string profilePicture, List<Profile> following)
        {
            Username = username;
            ProfilePicture = profilePicture;
            Following = following;
        }
    }
}
