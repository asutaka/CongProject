using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongProject.Entities
{
    public class tblAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(25)]
        public string UserName { get; set; }
        [StringLength(500)]
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(50)]
        public string Position { get; set; }
        public int RoleId { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        public int Team { get; set; }
        public bool IsLock { get; set; }
    }
}
