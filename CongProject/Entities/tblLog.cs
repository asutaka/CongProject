using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongProject.Entities
{
    public class tblLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public byte Action { get; set; }
        [StringLength(25)]
        public string TableName { get; set; }
        [StringLength(4000)]
        public string Object { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Account { get; set; }
    }
}
