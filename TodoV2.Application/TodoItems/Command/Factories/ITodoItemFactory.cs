using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Domain.Models;

namespace TodoV2.Application.TodoItems.Command.Factories
{
    public interface ITodoItemFactory
    {
        public TodoItem createTodoItem(TodoItemCommandModel todo);
    }
}
