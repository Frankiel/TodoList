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

        public void Add(NoteCreateDto note)
        {
            Note result = mapper.Map<Note>(note);
            todoListContext.Notes.Add(new Note(){Text = note.Text, CategoryId = 1});
            todoListContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var noteToRemove = todoListContext.Notes.FirstOrDefault(note => note.Id == id);

            todoListContext.Notes.Remove(noteToRemove);
            todoListContext.SaveChanges();
        }

        public void Update(int id, NoteCreateDto note)
        {
            var noteToUpdate = todoListContext.Notes.FirstOrDefault(noteEntity => noteEntity.Id == id);

            mapper.Map(note, noteToUpdate);
            todoListContext.SaveChanges();
        }
    }
}
