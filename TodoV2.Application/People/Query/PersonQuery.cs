using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoV2.Application.Interfaces;

namespace TodoV2.Application.People.Query
{
    public class PersonQuery : IPersonQuery
    {
        IDatabaseService _database;
        IMapper _mapper;

        public PersonQuery(IDatabaseService database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public PersonQueryModel GetPerson(int id)
        {
            var queriedPerson = _database.People.Where(p => p.IsDeleted == false && p.Id == id).FirstOrDefault();
            var person = _mapper.Map<PersonQueryModel>(queriedPerson);
            if(person == null)
            {
                return null;
            }
            return person;
        }

        
    }
}
