﻿using System.Collections.Generic;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Repository
{
    public interface INoteRepository
    {
        IEnumerable<NoteDto> GetAll();

        NoteDto Get(int id);

        void Add(NoteDto note);

        void Delete(NoteDto note);

        void Save();
    }
}
