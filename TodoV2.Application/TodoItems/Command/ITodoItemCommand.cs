using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Application.TodoItems.Query;

namespace TodoV2.Application.TodoItems.Command
{
    public interface ITodoItemCommand
    {
        public TodoItemQueryModel AddTodoItem(TodoItemCommandModel todo, int personId);
        public TodoItemQueryModel ToggleIsDone(int todoId);
        public TodoItemQueryModel DeleteTodoItem(int todoId);

    }
}
