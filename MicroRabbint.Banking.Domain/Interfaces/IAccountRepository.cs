using System.Collections.Generic;
using MicroRabbint.Banking.Domain.Models;

namespace MicroRabbint.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}