using Microsoft.AspNetCore.Mvc;
using TodoV2.Application.TodoItems.Command;
using TodoV2.Application.TodoItems.Query;
using TodoV2.Domain.Models;

namespace TodoV2.Presentation.Controllers
{
    [Route("[controller]")]
    public class TodoItemController : Controller
    {
        ITodoItemCommand _command;
        ITodoItemQuery _query;
        public TodoItemController(ITodoItemCommand command,ITodoItemQuery query)
        {
            _command = command;
            _query = query;
        }

        [HttpPost("{id}")]
       public ActionResult<TodoItemQueryModel> AddTodoItem(TodoItemCommandModel todo,int id)
        {
            return _command.AddTodoItem(todo,id);
        }
        [HttpGet("{id}")]
        public ActionResult<List<TodoItemQueryModel>> GetTodoItem(int id)
        {
            return _query.GetTodoItems(id);

        }
        [HttpPut("toggle/{id}")]
        public ActionResult<TodoItemQueryModel> ToggleTodoItem(int id)
        {
            return _command.ToggleIsDone(id);
        }
        [HttpDelete("{id}")]
        public ActionResult<TodoItemQueryModel> DeleteTodoItem(int id)
        {
            return _command.DeleteTodoItem(id);
        }
    }
}
