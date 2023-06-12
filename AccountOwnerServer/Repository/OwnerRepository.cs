using Contracts;
using Entities;
using Entities.Models;
using System.Linq.Expressions;

namespace Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

      
    }
}
