using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Entities;
using Library.Models;

namespace Library.DAL.Impl.Mappers
{
    public static class AuthorMapper
    {
        public static DTOAuthor Map(Author entity)
        {
            return new DTOAuthor()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.DateOfBirth
            };
        }
        public static Author Unmap(DTOAuthor model)
        {
            return new Author()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth
            };
        }
    }
}
