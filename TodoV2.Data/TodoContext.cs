using Microsoft.EntityFrameworkCore;
using TodoV2.Application.Interfaces;
using TodoV2.Domain.Models;

namespace TodoV2.Data
{
    public class TodoContext:DbContext,IDatabaseService
    {
        public TodoContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<TodoItem> Todos { get; set; }

        void IDatabaseService.SaveChanges()
        {
            SaveChanges();
        }
    }
}