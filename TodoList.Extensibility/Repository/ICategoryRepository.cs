using System.Collections.Generic;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryDto> GellAll();

        CategoryDto Get(int id);

        void Add(CategoryCreateUpdateDto category);

        void Update(int id, CategoryCreateUpdateDto category);

        void Delete(int id);
    }
}
