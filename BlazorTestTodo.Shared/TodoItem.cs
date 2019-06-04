using System.ComponentModel.DataAnnotations;

namespace BlazorTestTodo.Shared
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Title must be 20 characters or less.")]
        public string Title { get; set; }

        [Required]
        public string ShortDesc { get; set; }

        public int PriorityNumber { get; set; }

        public bool IsDone { get; set; }
    }
}
