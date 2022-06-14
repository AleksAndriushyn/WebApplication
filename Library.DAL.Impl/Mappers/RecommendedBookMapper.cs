using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public static class RecommendedBookMapper
    {
        public static DTORecommendedBook Map(RecommendedBook entity)
        {
            return new DTORecommendedBook()
            {
                Id = entity.Id,
                Pages = entity.Pages,
                Title = entity.Title,
                Text = entity.Text,
                Price = entity.Price
            };
        }
        public static RecommendedBook Unmap(DTORecommendedBook model)
        {
            return new RecommendedBook()
            {
                Id = model.Id,
                Pages = model.Pages,
                Title = model.Title,
                Text = model.Text,
                Price = model.Price
            };
        }
    }
    
}
