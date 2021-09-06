using System;

namespace CongProject.Model
{
    public class PlanModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PlanDate { get; set; }
        public int GroupdId { get; set; }
        public string Content { get; set; }
        public string Device { get; set; }
        public int AccountId { get; set; }
        public bool Result { get; set; }
    }
}
