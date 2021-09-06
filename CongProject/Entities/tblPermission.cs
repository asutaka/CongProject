using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongProject.Entities
{
    public class tblPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ComponentId { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
    }
}
