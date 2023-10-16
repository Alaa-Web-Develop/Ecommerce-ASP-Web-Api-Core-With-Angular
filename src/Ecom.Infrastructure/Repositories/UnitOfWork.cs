using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICateogryRepository CateogryRepos { get; }

        public IProductRepository ProductRepos { get; }
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            CateogryRepos = new CateogryRepository(context);
            ProductRepos = new ProductRepository(context);
        }
    }
}
