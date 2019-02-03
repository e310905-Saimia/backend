using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTask1.Models;
using WebApiTask1.Services;

namespace WebApiTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        //GET: api/persons
        [HttpGet]
        public ActionResult Get()
        {
            var persons = new List<Person>
            {
                new Person("James", 55),
                new Person("Lisa", 35)
            };

            return new JsonResult(persons);
        }

        //GET: api/persons/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return new JsonResult(_personService.Read(id));
        }

        //GET: api/persons/jouni
        [HttpGet("/person/{name}")]
        public ActionResult<Person> GetPerson(string name)
        {
            return new JsonResult(_personService.Read(name));
        }
    }
}