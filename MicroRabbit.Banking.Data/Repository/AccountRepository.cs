using System.Collections.Generic;
using MicroRabbint.Banking.Domain.Interfaces;
using MicroRabbint.Banking.Domain.Models;
using MicroRabbit.Banking.Data.Context;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}