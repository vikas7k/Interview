using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
  public  class MemoryRepository<T> : IRepository<T> where T : IStoreable
    {
        private List<T> store;

        public MemoryRepository()
        {
            store = new List<T>();
        }

        public IEnumerable<T> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(IComparable id)
        {
            
        }

        public void Save(T item)
        {
           
        }

        public T FindById(IComparable id)
        {
            throw new NotImplementedException();
        }

        private static Predicate<T> StoreIdMatch(IComparable id)
        {
            return i => i.Id.Equals(id);
        }
    }
}
