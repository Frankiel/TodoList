using System.Collections.Generic;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryDto> GellAll();

        CategoryDto Get(int id);

        void Add(CategoryAddUpdateDto category);

        void Update(int id, CategoryAddUpdateDto category);

        void Delete(int id);
    }
}
