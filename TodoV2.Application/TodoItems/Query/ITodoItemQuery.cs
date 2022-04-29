using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Domain.Models;

namespace TodoV2.Application.TodoItems.Query
{
    public interface ITodoItemQuery
    {
        public List<TodoItemQueryModel> GetTodoItems(int personId);
        

    }
}
