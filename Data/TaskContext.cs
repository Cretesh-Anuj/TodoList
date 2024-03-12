using Microsoft.EntityFrameworkCore;
using Task = TodoList.Models.Task;

namespace TodoList.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }
        public DbSet<Task> Tasks{ get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Task>()
        //        .HasKey(c => c.Id);
        //}
    }
}
