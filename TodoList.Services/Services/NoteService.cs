using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;
using TodoList.Extensibility.Services;
using TodoList.Extensibility.Validators;

namespace TodoList.Services.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository noteRepository;
        private readonly INoteValidator noteValidator;

        public NoteService(INoteRepository noteRepository, INoteValidator noteValidator)
        {
            this.noteRepository = noteRepository;
            this.noteValidator = noteValidator;
        }
        public IEnumerable<NoteDto> GetAllNotes()
        {
            return noteRepository.GetAll();
        }

        public IActionResult GetNote(int id)
        {
            if (!noteValidator.ValidateExistence(id))
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(noteRepository.Get(id));
        }

        public IActionResult Add(NoteCreateDto note)
        {
            if (!noteValidator.ValidateAdd(note))
            {
                return new BadRequestResult();
            }

            noteRepository.Add(note);

            return new NoContentResult();
        }

        public IActionResult Delete(int id)
        {
            if (!noteValidator.ValidateExistence(id))
            {
                return new NotFoundResult();
            }

            noteRepository.Delete(id);

            return new NoContentResult();
        }

        public IActionResult Update(int id, NoteCreateDto note)
        {
            if (!noteValidator.ValidateExistence(id) || !noteValidator.ValidateAdd(note))
            {
                return new BadRequestResult();
            }

            noteRepository.Update(id, note);

            return new NoContentResult();
        }
    }
}
