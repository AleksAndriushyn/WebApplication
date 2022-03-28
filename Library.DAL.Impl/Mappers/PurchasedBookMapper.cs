using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public class PurchasedBookMapper
    {
        public static DTOPurchasedBook Map(PurchasedBook entity)
        {
            return new DTOPurchasedBook()
            {
                Id = entity.Id,
                Date = entity.Date,
                BookId = entity.BookId,
                Books = BookMapper.Map(entity.Books)
            };
        }
        public static PurchasedBook Unmap(DTOPurchasedBook model)
        {
            return new PurchasedBook()
            {
                Id = model.Id,
                Date = model.Date,
                BookId = model.BookId,
                Books = BookMapper.Unmap(model.Books)
            };
        }
    }
}
