using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BlazorTestTodo.Server.Services;
using BlazorTestTodo.Shared;

namespace BlazorTestTodo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoDataController : ControllerBase
    {
        public TodoService todoService { get; set; }

        public TodoDataController(TodoService paramTodoService)
        {
            todoService = paramTodoService;
        }

        // GET api/tododata
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetAllTodos()
        {
            return todoService.todos;
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTodo(int id)
        {
            TodoItem todoItem = todoService.todos.SingleOrDefault(x => x.Id == id);
            if (todoItem != null)
            {
                todoService.todos.Remove(todoItem);
            }
            return Ok();
        }

        [HttpPost]
        public ActionResult AddTodo(TodoItem todoItem)
        {
            if (todoService.todos.Count() > 0)
            {
                todoItem.Id = todoService.todos.Max(x => x.Id) + 1;
            }
            else
            {
                todoItem.Id = 1;
            }
            todoService.todos.Add(todoItem);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateTodo(TodoItem todoItem)
        {
            TodoItem originalItem = todoService.todos.FirstOrDefault(x => x.Id == todoItem.Id);
            if (originalItem != null)
            {
                originalItem.Title = todoItem.Title;
                originalItem.ShortDesc = todoItem.ShortDesc;
                originalItem.PriorityNumber = todoItem.PriorityNumber;
                originalItem.IsDone = todoItem.IsDone;
            }
            return Ok();
        }
    }
}