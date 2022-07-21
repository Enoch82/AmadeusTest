using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBooksAmadeus.Model;

namespace ApiBooksAmadeus.Repository
{
    public class UnitOfWork : IUnitOfWork
    
    {
        private readonly MyDbContext _context;
        public UnitOfWork(MyDbContext context)
        {
            _context = context;
            Book = new BookRepository(_context);
            Store = new StoreRepsitory(_context);
        }

        public IBookRepository Book { get; private set; }
        public IStoreRepository Store { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
