using Library.DAL.Abstract;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl
{
    public class PurchasedBookRepository : GenericRepository<PurchasedBook>, IPurchasedBookRepository
    {
        public PurchasedBookRepository(LibraryContext context) : base(context)
        {

        }
    }
}
