using System.Collections.Generic;
using BlazorTestTodo.Shared;

namespace BlazorTestTodo.Server.Services
{
    public class TodoService
    {
        public List<TodoItem> todos { get; set; } = new List<TodoItem>()
        {
            new TodoItem() {
                Id = 1,
                Title = "Check Email",
                ShortDesc = "Check all new emails.",
                PriorityNumber = 1,
                IsDone = false
            },
            new TodoItem() {
                Id = 2,
                Title = "Book Meeting",
                ShortDesc = "Book a meeting discussing a new project.",
                PriorityNumber = 2,
                IsDone = false
            }
        };
    }
}
