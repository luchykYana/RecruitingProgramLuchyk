using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Data.Interfaces
{
    public interface IService<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public void Add(T item);
        public T UpdateById(int id, T item);
        public void DeleteById(int id);
    }
}
