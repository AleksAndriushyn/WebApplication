using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;
using Library.Models;
using System.Linq;
using Library.DAL.Impl.Mappers;
using Library.Entities;

namespace Library.Bl.Impl
{
    public class PurchasedBookService : PurchasedBookRepository, IPurchasedBookService
    {
        public PurchasedBookService(LibraryContext context) : base(context)
        {

        }

        public List<DTOPurchasedBook> List()
        {
            return this.EntityList().Select(obj => PurchasedBookMapper.Map(obj)).ToList();
        }

        public void Insert(DTOPurchasedBook purchasedBook)
        {
            this.EntityInsert(PurchasedBookMapper.Unmap(purchasedBook));
        }

        public DTOPurchasedBook Get(int id)
        {
            return PurchasedBookMapper.Map(this.GetEntity(id));
        }

        public void Update(DTOPurchasedBook model)
        {
            this.UpdateEntity(PurchasedBookMapper.Unmap(model));
        }

        public IEnumerable<DTOPurchasedBook> Buy(Book book)
        {
            var purchasedBooks = this.List();
            purchasedBooks.Add(new DTOPurchasedBook() { BookId = book.Id, Date = DateTime.Now, Books=BookMapper.Map(book)});
            foreach(var pb in purchasedBooks)
            {
                this.Insert(pb);
            }
                
            return purchasedBooks;
        }
    }
}
