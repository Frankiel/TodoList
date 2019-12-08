using System;
using System.Collections.Generic;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;

namespace TodoList.Domain.Repository
{
    public class NoteRepository : INoteRepository
    {
        public IEnumerable<NoteDto> Get()
        {
            return new List<NoteDto>();
        }

        public void Add(NoteDto note)
        {
            throw new NotImplementedException();
        }

        public void Delete(NoteDto note)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
