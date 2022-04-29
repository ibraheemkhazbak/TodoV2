using Microsoft.AspNetCore.Mvc;
using TodoV2.Application.People.Command;
using TodoV2.Application.People.Query;

namespace TodoV2.Presentation.Controllers { 
    [Route("[controller]")]
    public class PersonController : Controller
    {
        IPersonCommand _command;
        IPersonQuery _query;

        public PersonController(IPersonCommand command, IPersonQuery query)
        {
            _command = command;
            _query = query;
        }

        [HttpPost]
        public ActionResult<PersonQueryModel> AddPerson(PersonCommandModel person)
        {
            return _command.AddPerson(person);
        }
        [HttpPut]
        public ActionResult<PersonQueryModel> UpdatePerson(PersonCommandModel person)
        {
            return _command.AddPerson(person);
        }
        [HttpGet("{id}")]
        public ActionResult<PersonQueryModel> AddPerson(int id)
        {
            return _query.GetPerson(id);
        }
        [HttpDelete("{id}")]
        public ActionResult<PersonQueryModel> DeletePerson(int id)
        {
            return _command.DeletePerson(id);
        }
    }
}
