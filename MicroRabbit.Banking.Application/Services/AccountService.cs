using System.Collections.Generic;
using MicroRabbint.Banking.Domain.Interfaces;
using MicroRabbint.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}