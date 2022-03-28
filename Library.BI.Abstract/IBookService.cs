using Library.DAL.Abstract;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IBookService : IBookRepository, IGenericService<DTOBook>
    {
        public IEnumerable<DTOBook> FindByTitle(string searchTitle);
        public IEnumerable<DTOBook> GetBookInfo(Book book);
    }
}
