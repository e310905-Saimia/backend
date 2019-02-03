using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Models;
using WebApiExample.Repositories;
using WebApiExample.Services;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonService _personService;

        public PersonsController(IPersonRepository personRepository, IPersonService personService)
        {
            _personRepository = personRepository;
            _personService = personService;
        }


        // GET: api/persons
        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            return new JsonResult(_personService.Read());
        }

        // GET: api/persons/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return new JsonResult(_personService.Read(id));
        }


       //POST:api/persons
        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            var newPerson = _personService.Create(person);
            return newPerson;
        }
        
       //PUT:api/persons/5
        [HttpPut("{id}")]
        public ActionResult<Person> Put(int id, Person person)
        {
            var updatedPerson = _personService.Update(id,person);
            return updatedPerson;
        }

        //DELETE:api/persons/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        { 
            _personService.Delete(id);
            return new NoContentResult();
        }
    }
}