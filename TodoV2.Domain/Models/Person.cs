using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoV2.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
        public bool IsDeleted { get; set; }
    }
}

