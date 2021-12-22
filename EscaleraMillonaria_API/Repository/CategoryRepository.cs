using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Task<List<CategoryDto>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
