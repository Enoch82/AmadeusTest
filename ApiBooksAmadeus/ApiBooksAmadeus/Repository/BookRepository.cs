using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBooksAmadeus.Model;

namespace ApiBooksAmadeus.Repository
{
    public class BookRepository : GenericRepository<BookModel>, IBookRepository
    {
        public BookRepository(MyDbContext context) : base(context)
        {
        }
    }
}
