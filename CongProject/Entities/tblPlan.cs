using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongProject.Entities
{
    public class tblPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string KeHoachSo { get; set; }
        public DateTime PlanDate { get; set; }
        [StringLength(2000)]
        public string PlanContent { get; set; }
        [StringLength(2000)]
        public string RequireContent { get; set; }
        [StringLength(100)]
        public string SolutionKey { get; set; }
        [StringLength(2000)]
        public string SolutionValue { get; set; }
        [StringLength(100)]
        public string RiskKey { get; set; }
        [StringLength(2000)]
        public string RiskValue { get; set; }
        [StringLength(100)]
        public string ResourceKey { get; set; }
        [StringLength(2000)]
        public string ResourceValue { get; set; }
        [StringLength(100)]
        public string UserKey { get; set; }
        [StringLength(2000)]
        public string UserValue { get; set; }
        [StringLength(50)]
        public string Group { get; set; }
        public DateTime ImpDate { get; set; }
        [StringLength(500)]
        public string District { get; set; }
        public byte Status { get; set; }
        [StringLength(100)]
        public string Status_Text { get; set; }
        public DateTime ModifiedDate { get; set; }
        [StringLength(200)]
        public string CreatedBy { get; set; }
        public int Team { get; set; }
        public string DonViYeuCau { get; set; }
        public int LoaiYeuCau { get; set; }
        public string ChucDanh { get; set; }
    }
}
