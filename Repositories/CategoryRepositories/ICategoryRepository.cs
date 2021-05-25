using POS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Repositories.CategoryRepositories
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        List<Category> GetAllCategoryByGroupCode(string GroupCode);

        Category Find(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        void Save();
    }
}
