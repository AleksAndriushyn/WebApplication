using Library.DAL.Abstract;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl
{
    public class RecommendedBookRepository : GenericRepository<RecommendedBook>, IRecommendedBookRepository
    {
        public RecommendedBookRepository(LibraryContext context) : base(context)
        {

        }
    }
}
