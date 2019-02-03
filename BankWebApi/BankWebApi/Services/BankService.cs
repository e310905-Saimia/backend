using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankWebApi.Models;
using BankWebApi.Repositories.Interfaces;
using BankWebApi.Services.Interfaces;

namespace BankWebApi.Services
{
    public class BankService:IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public List<Bank> Read()
        {
            var banks = _bankRepository.Read();

            return banks;
        }

        public Bank Read(int id)
        {
            var bank = _bankRepository.Read(id);
            bank.Account = bank.Account.ToList();
            bank.Customer = bank.Customer.ToList();
            return bank;
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
