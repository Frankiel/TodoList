using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TodoList.Domain.Models;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;

namespace TodoList.Domain.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly TodoListContext todoListContext;
        private readonly IMapper mapper;

        public NoteRepository(IMapper mapper, TodoListContext todoListContext)
        {
            this.todoListContext = todoListContext;
            this.mapper = mapper;
        }
        public IEnumerable<NoteDto> GetAll()
        {
            var results = todoListContext.Notes.ToList();

            return mapper.Map<List<NoteDto>>(results);
        }

        public NoteDto Get(int id)
        {
            return mapper.Map<NoteDto>(todoListContext.Notes.FirstOrDefault(note => note.Id == id));
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
