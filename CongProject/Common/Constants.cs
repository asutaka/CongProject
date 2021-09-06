using CongProject.Entities;

namespace CongProject.Common
{
    public static class Constants
    {
        public static string DefaultPassword = "12345";
        public static string SecretKey = "MyKey";
        public static AppDbContext appDbContext;
        public static tblAccount entityAccount = new tblAccount();
    }
}
