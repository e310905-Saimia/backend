using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankWebApi.Models;
using BankWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BankWebApi.Repositories
{
    public class BankRepository:IBankRepository
    {
        private readonly BankdbContext _context;

        public BankRepository(BankdbContext context)
        {
            _context = context;
        }

        public List<Bank> Read()
        {
            return _context.Bank.ToListAsync().Result;
        }

        public Bank Read(int id)
        {
            return _context.Bank
                .Include(b=>b.Account)
                
                .Include(b=>b.Customer)
                .FirstOrDefault(b => b.Id == id);
        }

        public Bank Create(Bank bank)
        {
            throw new NotImplementedException();
        }

        public Bank Update(int id, Bank bank)
        {
            throw new NotImplementedException();
        }

        public Bank Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
