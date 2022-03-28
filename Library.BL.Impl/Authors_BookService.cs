using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;
using Library.Models;
using System.Linq;
using Library.DAL.Impl.Mappers;

namespace Library.Bl.Impl
{
    public class Authors_BookService : Authors_BookRepository, IAuthors_BookService
    {
        public Authors_BookService(LibraryContext context) : base(context)
        {

        }
        public List<DTOAuthors_Book> List()
        {
            return this.EntityList().Select(obj => Authors_BookMapper.Map(obj)).ToList();
        }
        public void Insert(DTOAuthors_Book authors_book)
        {
            this.EntityInsert(Authors_BookMapper.Unmap(authors_book));
        }

        public DTOAuthors_Book Get(int id)
        {
            return Authors_BookMapper.Map(this.GetEntity(id));
        }

        public void Update(DTOAuthors_Book model)
        {
            this.UpdateEntity(Authors_BookMapper.Unmap(model));
        }
    }
}
