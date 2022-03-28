using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;
using System.Linq;
using Library.Models;
using Library.DAL.Impl.Mappers;

namespace Library.Bl.Impl
{
    public class ReaderService : ReaderRepository, IReaderService
    {
        public ReaderService(LibraryContext context) : base(context)
        {

        }

        public List<DTOReader> List()
        {
            return this.EntityList().Select(obj => ReaderMapper.Map(obj)).ToList();
        }
        public void Insert(DTOReader reader)
        {
            this.EntityInsert(ReaderMapper.Unmap(reader));
        }

        public DTOReader Get(int id)
        {
            return ReaderMapper.Map(this.GetEntity(id));
        }

        public void Update(DTOReader model)
        {
            this.UpdateEntity(ReaderMapper.Unmap(model));
        }

    }
}
