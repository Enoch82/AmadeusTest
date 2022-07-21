using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBooksAmadeus.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Book { get; }
        IStoreRepository Store { get; }
        int Complete();
    }
}
