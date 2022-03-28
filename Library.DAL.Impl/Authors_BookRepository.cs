using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Library.DAL.Abstract;
using System.Linq;

namespace Library.DAL.Impl
{
    public class Authors_BookRepository : GenericRepository<Authors_Book>, IAuthors_BookRepository
    {
        public Authors_BookRepository(LibraryContext context) : base(context)
        {

        }
    }
}
