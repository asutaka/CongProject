namespace CongProject.Model
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string FullName { get; set; }
        public int GroupId { get; set; }
        public bool Lock { get; set; }
    }
}
