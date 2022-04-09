using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Core
{
    // where indica que T debe ser AggregateRoot
    public interface IRepository<T, TId> where T : AggregateRoot<TId>
    {
        Task FindByIdAsync(TId id);
        Task CreateAsync(T obj);
    }
}
