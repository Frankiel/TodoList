﻿using System.Collections.Generic;
using AutoMapper;
using TodoList.Domain.Models;
using TodoList.Extensibility.Dto;

namespace TodoList.WebApi.Mappings
{
    public class TodoMappingProfile : Profile
    {
        public TodoMappingProfile()
        {
            CreateMap<Note, NoteDto>();
            CreateMap<NoteDto, Note>();
            CreateMap<NoteCreateUpdateDto, Note>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CategoryCreateUpdateDto, Category>();
        }
    }
}
