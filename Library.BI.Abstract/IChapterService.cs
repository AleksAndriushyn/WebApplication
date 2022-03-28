using Library.DAL.Abstract;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IChapterService : IChapterRepository, IGenericService<DTOChapter>
    {
    }
}
