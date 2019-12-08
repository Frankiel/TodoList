using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Domain.Models;
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
    }
}
