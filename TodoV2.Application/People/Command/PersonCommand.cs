using AutoMapper;
using TodoV2.Application.Interfaces;
using TodoV2.Application.People.Query;
using TodoV2.Domain.Models;

namespace TodoV2.Application.People.Command
{
    public class PersonCommand : IPersonCommand
    {
        IMapper _mapper;
        IDatabaseService _database;
        public PersonCommand(IMapper mapper,IDatabaseService database)
        {
            _mapper = mapper;
            _database = database;
        }
        public PersonQueryModel AddPerson(PersonCommandModel addedPerson)
        {
            var person = _mapper.Map<Person>(addedPerson);
            _database.People.Add(person);
            _database.SaveChanges();
            var mappedPerson = _mapper.Map<PersonQueryModel>(person);
            return mappedPerson;
        }

        public PersonQueryModel DeletePerson(int id)
        {
            var person = _database.People.Find(id);
            person.IsDeleted = true;
            _database.SaveChanges();
            var mappedPerson = _mapper.Map<PersonQueryModel>(person);
            return mappedPerson;
            
        }

        public PersonQueryModel UpdatePerson(int id, PersonCommandModel updatedPerson)
        {
            var person = _database.People.Find(id);
             
            person.Name = updatedPerson.Name; ;

            if (person == null)
            {
                return null;
            }
            var mappedPerson = _mapper.Map<PersonQueryModel>(person);
            return mappedPerson;
        }
    }
}
