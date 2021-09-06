namespace CongProject.Model
{
    public class UserConfigModel
    {
        public ConnectionModel Connection { get; set; }
        public LoginModel Login { get; set; }
    }
    public class ConnectionModel
    {
        public string IP { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
