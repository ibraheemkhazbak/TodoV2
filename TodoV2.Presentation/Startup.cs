using Microsoft.EntityFrameworkCore;
using TodoV2.Application.Interfaces;
using TodoV2.Application.People.Command;
using TodoV2.Application.People.Query;
using TodoV2.Application.TodoItems.Command;
using TodoV2.Application.TodoItems.Command.Factories;
using TodoV2.Application.TodoItems.Query;
using TodoV2.Data;

namespace TodoV2.Presentation
{
    public class Startup
    {

        public void AddServices(IServiceCollection services,string connectionString)
        {

            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<TodoContext>(opt => opt.UseSqlServer(connectionString));
            services.AddAutoMapper(typeof(Program));

            services.AddTransient<IPersonCommand, PersonCommand>();
            services.AddTransient<IPersonQuery, PersonQuery>();
            services.AddTransient<IDatabaseService, TodoContext>();
            services.AddTransient<ITodoItemFactory, TodoItemFactory>();
            services.AddTransient<ITodoItemCommand, TodoItemCommand>();
            services.AddTransient<ITodoItemQuery, TodoItemQuery>();


        }

    
    
    }

}
