using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Application.Interfaces;
using TodoV2.Domain.Models;

namespace TodoV2.Application.TodoItems.Query
{
    public class TodoItemQuery : ITodoItemQuery
    {
        IDatabaseService _database;
        IMapper _mapper;
        public TodoItemQuery(IDatabaseService database,IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public List<TodoItemQueryModel> GetTodoItems(int personId)
        {
            var todoItems = _database.Todos.Where(t => t.PersonId == personId && t.IsDeleted == false).ToList();
            var todoItemsQuery = _mapper.Map<List<TodoItemQueryModel>>(todoItems);

            return todoItemsQuery;
        }


    }
}
