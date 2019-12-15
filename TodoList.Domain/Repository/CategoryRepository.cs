using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TodoList.Domain.Models;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;

namespace TodoList.Domain.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TodoListContext todoListContext;
        private readonly IMapper mapper;

        public CategoryRepository(TodoListContext todoListContext, IMapper mapper)
        {
            this.todoListContext = todoListContext;
            this.mapper = mapper;
        }
        public IEnumerable<CategoryDto> GellAll()
        {
            var results = todoListContext.Categories.ToList();

            return mapper.Map<List<CategoryDto>>(results);
        }

        public CategoryDto Get(int id)
        {
            return mapper.Map<CategoryDto>(todoListContext.Categories.FirstOrDefault(category=>category.Id==id));
        }

        public void Add(CategoryAddUpdateDto category)
        {
            var result = mapper.Map<Category>(category);

            todoListContext.Add(result);
            todoListContext.SaveChanges();
        }

        public void Update(int id, CategoryAddUpdateDto category)
        {
            var categoryToUpdate = todoListContext.Categories.FirstOrDefault(categoryEntity => categoryEntity.Id == id);

            mapper.Map(category, categoryToUpdate);
            todoListContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryToRemove = todoListContext.Categories.FirstOrDefault(category => category.Id == id);

            todoListContext.Categories.Remove(categoryToRemove);
            todoListContext.SaveChanges();
        }
    }
}
