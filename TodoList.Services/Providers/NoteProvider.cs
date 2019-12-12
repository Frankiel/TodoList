using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoList.Domain.Models;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Providers;
using TodoList.Extensibility.Repository;

namespace TodoList.Services.Providers
{
    public class NoteProvider : INoteProvider
    {
        private readonly INoteRepository noteRepository;

        public NoteProvider(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }
        public IEnumerable<NoteDto> GetAllNotes()
        {
            return noteRepository.GetAll();
        }

        public NoteDto GetNote(int id)
        {
            return noteRepository.Get(id);
        }
    }
}
