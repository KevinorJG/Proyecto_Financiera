﻿using Financiera.AppCore.IServices;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.AppCore.Services
{
    public class AccountService : IAccountServices
    {
        protected readonly IAccountRepository repository;

        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> DeleteAccount(int id)
        {
           return await repository.DeleteAccount(id);
        }

        public DataTable GetAccountsByDni(string dni)
        {
            return repository.GetAccountsByDni(dni);
        }

        public DataTable GetAccounts()
        {
            return repository.GetAccounts();
        }

        public Client GetClientByDni(string dni)
        {
            return repository.GetClientByDni(dni);
        }

        public async Task<int> InsertAccount(Account entity)
        {
            return await repository.InsertAccount(entity);
        }

    
    }
}
