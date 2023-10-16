using Ecom.Core.Entities;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Repositories
{
    public class CateogryRepository : GenericRepository<Cateogry>, ICateogryRepository
    {
        public CateogryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
