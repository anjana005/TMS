using Microsoft.EntityFrameworkCore;
using TMS.Data;

namespace TMS.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskData> TaskDatas { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }

    }
}
