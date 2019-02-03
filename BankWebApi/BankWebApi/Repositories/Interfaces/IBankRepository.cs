using System.Collections.Generic;
using BankWebApi.Models;

namespace BankWebApi.Repositories.Interfaces
{
    public interface IBankRepository
    {
        List<Bank> Read();
        Bank Read(int id);
        Bank Create(Bank bank);
        Bank Update(int id, Bank bank);
        Bank Delete(int id);
    }
}
