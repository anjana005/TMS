using System.ComponentModel.DataAnnotations;

namespace TMS.Data
{
    public class TaskAssignment
    {
        [Key]
        public int Id { get; set; } // Primary Key
        public int TaskId { get; set; } // Foreign Key referencing Task.TaskId
        public int Assignedto { get; set; } // Foreign Key referencing Users.UserId (assigned employee)
        public int AssignedBy { get; set; } // Foreign Key referencing Users.UserId (assigning manager)
        public string? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }


    }

}
