using System.Collections.Generic;

namespace HomeWork2019._12._02.AbstractModels
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Delete(T item);
        void Delete(int id);
        void Update(T item);
        IEnumerable<T> GetAll();
    }
}
