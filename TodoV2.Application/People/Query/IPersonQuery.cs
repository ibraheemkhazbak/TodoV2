using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoV2.Application.People.Query
{
    public interface IPersonQuery
    {
        public PersonQueryModel GetPerson(int id);


    }
}
