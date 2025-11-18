namespace LystfiskerPortalen.ClassLibrary
{
    public class Profile
    {
        //Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
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
