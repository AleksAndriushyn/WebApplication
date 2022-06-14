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
    public class RecommendedBookService : RecommendedBookRepository, IRecommendedBookService
    {
        public RecommendedBookService(LibraryContext context) : base(context)
        {

        }
        public List<DTORecommendedBook> List()
        {
            return this.EntityList().Select(obj => RecommendedBookMapper.Map(obj)).ToList();
        }
        public void Insert(DTORecommendedBook recommendedBook)
        {
            this.EntityInsert(RecommendedBookMapper.Unmap(recommendedBook));
        }

        public DTORecommendedBook Get(int id)
        {
            return RecommendedBookMapper.Map(this.GetEntity(id));
        }

        public void Update(DTORecommendedBook model)
        {
            this.UpdateEntity(RecommendedBookMapper.Unmap(model));
        }
    }
}
