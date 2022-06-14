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
        IEnumerable<DTOBook> FindByTitle(string searchTitle);
        IEnumerable<DTOBook> GetBookInfo(DTOBook book);
        IEnumerable<DTOBook> GetRecommendedBooks();
    }
}
