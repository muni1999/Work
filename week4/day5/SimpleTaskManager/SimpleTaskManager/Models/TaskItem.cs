using System.ComponentModel.DataAnnotations;

namespace SimpleTaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}
