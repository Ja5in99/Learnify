using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace Infrastructure
{
    public interface ICategoryRepository
    {
        Task<IReadOnlyList<Category>> GetCategoriesAsync();

        Task<Category> GetCategoriesByIdAsync(int id);
    }
}