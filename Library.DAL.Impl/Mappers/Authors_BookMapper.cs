using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public class Authors_BookMapper
    {
        public static DTOAuthors_Book Map(Authors_Book entity)
        {
            return new DTOAuthors_Book()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                AuthorId = entity.AuthorId,
                BookId = entity.BookId
                //Author = AuthorMapper.Map(entity.Author),
                //Book = BookMapper.Map(entity.Book)
            }; 
        }
        public static Authors_Book Unmap(DTOAuthors_Book model)
        {
            return new Authors_Book()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                AuthorId = model.AuthorId,
                BookId = model.BookId
            }; 
        }
    }
}
