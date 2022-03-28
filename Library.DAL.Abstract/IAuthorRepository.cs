using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Abstract
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        IEnumerable<Author> FindEntityByFirstName(string stringSearch);
        IEnumerable<Author> FindEntityByDate(DateTime searchDate);
    }
}
