using Library.Bl.Abstract;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public class Readers_CardMapper
    {
        public static DTOReaders_Card Map(Readers_Card entity)
        {
            return new DTOReaders_Card()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Date = entity.Date,
                BookId = entity.BookId,
                //Books = BookMapper.Map(entity.Books),
                ReaderId = entity.ReaderId
                //Reader = ReaderMapper.Map(entity.Reader)
            };
        }
        public static Readers_Card Unmap(DTOReaders_Card model)
        {
            return new Readers_Card()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Date = model.Date,
                BookId = model.BookId,
                //Books = BookMapper.Unmap(model.Book),
                ReaderId = model.ReaderId
            };
        }
    }
}
