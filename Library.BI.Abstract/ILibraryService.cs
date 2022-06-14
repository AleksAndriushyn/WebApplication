using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface ILibraryService
    {
        IEnumerable<DTOAuthor> FindByAmountOfBooks(int AmountOfBooks);
    }
}
