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
    public class Readers_CardService : Readers_CardRepository, IReaders_CardService
    {
        public Readers_CardService(LibraryContext context) : base(context)
        {

        }
        public List<DTOReaders_Card> List()
        {
            return this.EntityList().Select(obj => Readers_CardMapper.Map(obj)).ToList();
        }
        public void Insert(DTOReaders_Card readers_Card)
        {
            this.EntityInsert(Readers_CardMapper.Unmap(readers_Card));
        }
        public DTOReaders_Card Get(int id)
        {
            return Readers_CardMapper.Map(this.GetEntity(id));
        }
        public void Update(DTOReaders_Card model)
        {
            this.UpdateEntity(Readers_CardMapper.Unmap(model));
        }
    }
}
