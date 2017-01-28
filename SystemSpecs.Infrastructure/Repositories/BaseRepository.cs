using System.Collections.Generic;
using System.Linq;
using SystemSpecs.Core.Interface;

namespace SystemSpecs.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        protected List<T> _EntityList;

        public BaseRepository()
        {
            _EntityList = new List<T>();

            InitializeEntities();
        }

        protected abstract void InitializeEntities();

        public T Get(int index)
        {
            return _EntityList[index];
        }

        public IEnumerable<T> GetAll()
        {
            return _EntityList.AsEnumerable();
        }
    }
}