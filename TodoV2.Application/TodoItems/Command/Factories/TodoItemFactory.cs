using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Domain.Models;

namespace TodoV2.Application.TodoItems.Command.Factories
{
    public class TodoItemFactory : ITodoItemFactory
    {
        public TodoItem createTodoItem(TodoItemCommandModel todo)
        {
            var createdItem = new TodoItem();
            createdItem.Title = todo.Title;
            createdItem.IsDone = false;
            createdItem.CreatedAt = DateTime.Now;
            createdItem.Description = todo.Description;
            return createdItem;
        }
    }
}
