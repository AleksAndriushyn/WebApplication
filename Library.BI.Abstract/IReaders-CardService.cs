using Library.DAL.Abstract;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IReaders_CardService : IReaders_CardRepository, IGenericService<DTOReaders_Card>
    {
    }
}
