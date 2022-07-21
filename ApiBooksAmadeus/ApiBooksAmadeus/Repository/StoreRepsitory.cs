using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBooksAmadeus.Model;

namespace ApiBooksAmadeus.Repository
{
    public class StoreRepsitory : GenericRepository<StoreModel>, IStoreRepository
    {
        public StoreRepsitory(MyDbContext context) : base(context)
        {
        }
    }
}
