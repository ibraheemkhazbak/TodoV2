using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Domain.Models;

namespace TodoV2.Application.Interfaces
{
    public interface IDatabaseService
    {
        public DbSet<Person> People { get; set; }
        public DbSet<TodoItem> Todos { get; set; }
        void SaveChanges();
    }
}
