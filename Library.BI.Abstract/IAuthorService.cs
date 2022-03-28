using Library.DAL.Abstract;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IAuthorService : IAuthorRepository, IGenericService<DTOAuthor>
    {
        public IEnumerable<DTOAuthor> FindByFirstName(string searchString);
        public IEnumerable<DTOAuthor> FindByDate(DateTime searchDate);
    }
}
