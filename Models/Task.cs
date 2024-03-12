
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
