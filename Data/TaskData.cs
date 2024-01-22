using System.ComponentModel.DataAnnotations;

namespace TMS.Data
{
    public class TaskData
    {
        [Key]
        public int Id { get; set; } // Primary Key
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

}
