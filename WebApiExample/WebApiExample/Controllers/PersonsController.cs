using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Models;
using WebApiExample.Repositories;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // GET: api/persons
        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            return new JsonResult(_personRepository.Read());
        }

        // GET: api/persons/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return new JsonResult(_personRepository.Read(id));
        }


       //POST:api/persons
        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            var newPerson = _personRepository.Create(person);
            return newPerson;
        }
        
       //PUT:api/persons/5
        [HttpPut("{id}")]
        public ActionResult<Person> Put(int id, Person person)
        {
            var updatedPerson = _personRepository.Update(person);
            return updatedPerson;
        }

        //DELETE:api/persons/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        { 
            _personRepository.Delete(id);
            return new NoContentResult();
        }
    }
}