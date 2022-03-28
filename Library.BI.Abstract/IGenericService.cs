using Library.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IGenericService<T> where T: class
    {
        public List<T> List();
        public void Insert(T author);
        public T Get(int id);
        public void Update(T model);
    }
}
