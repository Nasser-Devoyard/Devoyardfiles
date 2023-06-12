using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository :RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        void IRepositoryBase<Account>.Create(Account entity)
        {
            throw new NotImplementedException();
        }

        void IRepositoryBase<Account>.Delete(Account entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Account> IRepositoryBase<Account>.FindAll()
        {
            throw new NotImplementedException();
        }

        IQueryable<Account> IRepositoryBase<Account>.FindByCondition(Expression<Func<Account, bool>> expression)
        {
            throw new NotImplementedException();
        }

        void IRepositoryBase<Account>.Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
