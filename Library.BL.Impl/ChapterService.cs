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
    public class ChapterService : ChapterRepository, IChapterService
    {
        public ChapterService(LibraryContext context) : base(context)
        {

        }
        public List<DTOChapter> List()
        {
            return this.EntityList().Select(obj => ChapterMapper.Map(obj)).ToList();
        }
        public void Insert(DTOChapter chapter)
        {
            this.EntityInsert(ChapterMapper.Unmap(chapter));
        }

        public DTOChapter Get(int id)
        {
            return ChapterMapper.Map(this.GetEntity(id));
        }

        public void Update(DTOChapter model)
        {
            this.UpdateEntity(ChapterMapper.Unmap(model));
        }
    }
}
