using Library.DAL.Abstract;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IPurchasedBookService : IPurchasedBookRepository, IGenericService<DTOPurchasedBook>
    {
        public IEnumerable<DTOPurchasedBook> Buy(Book book);
    }
}
