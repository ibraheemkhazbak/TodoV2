using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoV2.Domain.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDone { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public bool IsDeleted { get; set; }
    }
}
