using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public class ReaderMapper
    {
        public static DTOReader Map(Reader entity)
        {
            return new DTOReader()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
                //Readers_Cards = entity.Readers_Card.Select(obj => Readers_CardMapper.Map(obj)).ToList(),
            };
        }
        public static Reader Unmap(DTOReader model)
        {
            return new Reader()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
        }
    }
}

