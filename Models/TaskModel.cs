//This model represents the task data
using System.ComponentModel.DataAnnotations;

namespace MSwebPROJ1.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the Task Name.")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
