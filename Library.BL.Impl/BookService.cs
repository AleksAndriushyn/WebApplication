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
    public class BookService : BookRepository, IBookService
    {
        public BookService(LibraryContext context) : base(context)
        {

        }
       
        public List<DTOBook> List()
        {
            return this.EntityList().Select(obj => BookMapper.Map(obj)).ToList();
        }
        public void Insert(DTOBook book)
        {
            this.EntityInsert(BookMapper.Unmap(book));
        }

        public DTOBook Get(int id)
        {
            return BookMapper.Map(this.GetEntity(id));
        }

        public void Update(DTOBook model)
        {
            this.UpdateEntity(BookMapper.Unmap(model));
        }
        public IEnumerable<DTOBook> FindByTitle(string searchTitle)
        {
            var books = this.EntityList();
            books = books.Where(s => s.Title.ToLower().Contains(searchTitle)).ToList();
            return books.Select(obj => BookMapper.Map(obj)).ToList();
        }

        public IEnumerable<DTOBook> GetBookInfo(Book book)
        {
            var books = this.EntityList();
            books = books.Where(s => s.Id == book.Id).ToList();
            return books.Select(obj => BookMapper.Map(obj)).ToList();
        }
    }
}
