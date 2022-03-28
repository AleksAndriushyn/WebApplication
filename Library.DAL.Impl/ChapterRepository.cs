using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Library.DAL.Abstract;

namespace Library.DAL.Impl
{
    public class ChapterRepository : GenericRepository<Chapter>, IChapterRepository
    {
        public ChapterRepository(LibraryContext context) : base(context)
        {

        }
    }
}
