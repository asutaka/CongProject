using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongProject.Entities
{
    public class tblReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PlanId { get; set; }
        [StringLength(20)]
        public string KeHoachSo { get; set; }
        [StringLength(500)]
        public string District { get; set; }
        [StringLength(1000)]
        public string UserValue { get; set; }
        [StringLength(1000)]
        public string SolutionValue { get; set; }
        [StringLength(1000)]
        public string Result { get; set; }
        public DateTime ReportDate { get; set; }
        public string DeXuat { get; set; }
    }
}
