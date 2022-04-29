using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Application.People.Query;
using TodoV2.Domain.Models;

namespace TodoV2.Application.People.Command
{
    public interface IPersonCommand
    {
        public PersonQueryModel AddPerson(PersonCommandModel person);
        public PersonQueryModel UpdatePerson(int id,PersonCommandModel person);
        public PersonQueryModel DeletePerson(int id);
    }
}
