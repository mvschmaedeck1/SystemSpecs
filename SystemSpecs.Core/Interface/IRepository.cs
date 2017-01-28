using System.Collections.Generic;

namespace SystemSpecs.Core.Interface
{
    public interface IRepository<T>
    {
        T Get(int index);

        IEnumerable<T> GetAll();
    }
}