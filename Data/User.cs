using System.ComponentModel.DataAnnotations;

namespace TMS.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

}
