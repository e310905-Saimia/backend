using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApiTask1.Models;

namespace WebApiTask1.Repositories
{
    public class PersonRepository:IPersonRepository
    {
        private readonly PersondbContext _context;

        public PersonRepository(PersondbContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {

            throw new NotImplementedException();
        }

        public List<Person> Read()
        {
            return _context.Person
                .Include(p => p.Phone)
                .AsNoTracking()
                .ToList();
        }

        public Person Read(int id)
        {
            return _context.Person
                .Include(p=>p.Phone)
                .AsNoTracking()
                .FirstOrDefault(p => p.Id == id);
        }

        public Person Read(string name)
        {
            return _context.Person
                .Include(p => p.Phone)
                .AsNoTracking()
                .FirstOrDefault(p => p.Name.Contains(name));
        }

        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
