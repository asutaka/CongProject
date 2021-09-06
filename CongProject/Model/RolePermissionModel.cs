namespace CongProject.Model
{
    public class RolePermissionModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ObjectId { get; set; }
        public int Permission { get; set; }
    }
}
