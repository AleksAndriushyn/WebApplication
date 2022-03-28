using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Library.DAL.Abstract;

namespace Library.DAL.Impl
{
    public class Readers_CardRepository : GenericRepository<Readers_Card>, IReaders_CardRepository
    {
        public Readers_CardRepository(LibraryContext context) : base(context)
        {

        }
        
    }
}
