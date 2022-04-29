using AutoMapper;
using TodoV2.Application.People.Command;
using TodoV2.Application.People.Query;
using TodoV2.Application.TodoItems.Query;
using TodoV2.Domain.Models;

namespace TodoV2.Presentation
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<PersonCommandModel, Person>();
            CreateMap<Person,PersonQueryModel>();
            CreateMap<TodoItem, TodoItemQueryModel>();
        }
    }
}
