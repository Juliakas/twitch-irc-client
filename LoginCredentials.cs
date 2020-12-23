namespace IRC_protocol
{
    public class LoginCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Channel { get; set; }
        
        public LoginCredentials(string username, string password, string channel)
        {
            Username = username;
            Password = password;
            Channel = channel;
        }
    }
}
