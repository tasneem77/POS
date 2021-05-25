using POS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EZSportsContext _context;
        public CategoryRepository(EZSportsContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Delete(int id)
        {
            Category category = Find(id);
            _context.Categories.Remove(category);
        }

        public Category Find(int id)
        {
            return _context.Categories.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
           return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Where(a => a.Id == id).FirstOrDefault();
        }
        public List<Category> GetAllCategoryByGroupCode(string GroupCode)
        {
            //ItemGroup itemGroup = new ItemGroup();
            string[] id;
          
              List<Category> categories = new List<Category>();
           
            var cat1= _context.ItemMasters.Where(a => a.GroupCode == GroupCode).ToList();
            foreach(var cat in cat1) 
            {
                int catId =(int) cat.CategoryId;
                catId.ToString().Distinct();
                var category = _context.Categories.Where(c => c.Id == catId).Select(category => new Category
                {
                    Id = category.Id,
                    Name = category.Name,
                    Color = category.Color,
                    Description = category.Description,
                    Erpcode = category.Erpcode,
                    OrderNo = category.OrderNo,
                    Picture = category.Picture,
                    PrinterName = category.PrinterName
                }).ToList();
             //   category.Distinct();
                foreach (var cat2 in category.Distinct())
                {
                   
                    categories.Add(cat2);
                }
            }
           return categories;    
          //  return (List<Category>)categories.Distinct();

        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

      
    }
}
