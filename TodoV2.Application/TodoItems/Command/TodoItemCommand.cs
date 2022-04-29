using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Application.Interfaces;
using TodoV2.Application.People.Query;
using TodoV2.Application.TodoItems.Command.Factories;
using TodoV2.Application.TodoItems.Query;

namespace TodoV2.Application.TodoItems.Command
{
    public class TodoItemCommand : ITodoItemCommand
    {
        ITodoItemFactory _factory;
        IDatabaseService _database;
        IMapper _mapper;
        public TodoItemCommand(ITodoItemFactory factory, IDatabaseService database,IMapper mapper)
        {
            _factory = factory;
            _database = database;
            _mapper = mapper;
        }

        public TodoItemQueryModel AddTodoItem(TodoItemCommandModel todo, int personId)
        {
            var createdTodo = _factory.createTodoItem(todo);
            var person = _database.People.Find(personId);
 
            person.TodoItems.Add(createdTodo);
            _database.SaveChanges();
            var itemQuery = _mapper.Map<TodoItemQueryModel>(createdTodo);
            return itemQuery;
            
        }

        public TodoItemQueryModel ToggleIsDone(int todoId)
        {
            var item = _database.Todos.Find(todoId);
            item.IsDone = !item.IsDone;
            _database.SaveChanges();
            var itemQuery = _mapper.Map<TodoItemQueryModel>(item);
            return itemQuery;
        }
        public TodoItemQueryModel DeleteTodoItem(int todoId)
        {
            var item = _database.Todos.Find(todoId);
            item.IsDeleted = true;
            _database.SaveChanges();
            var itemQuery = _mapper.Map<TodoItemQueryModel>(item);
            return itemQuery;
        }
    }
}
