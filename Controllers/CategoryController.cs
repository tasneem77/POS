using Microsoft.AspNetCore.Mvc;
using POS_API.Models;
using POS_API.Repositories.CategoryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: api/Category
        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }
        [HttpGet]
        [Route("GetCategoryByGroupCode/{groupCode}")]
        public IEnumerable<Category> GetAllCategoryByGroupCode(string groupCode)
        {
            return _categoryRepository.GetAllCategoryByGroupCode(groupCode);
        }
    }
}
