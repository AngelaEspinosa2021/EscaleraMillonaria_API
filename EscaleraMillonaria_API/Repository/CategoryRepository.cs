using AutoMapper;
using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models;
using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetCategories()
        {
            List<Category> list = await _db.Categories.ToListAsync();

            return _mapper.Map<List<CategoryDto>>(list);
        }

        public async Task<CategoryDto> GetCategoryById(int id)
        {
            Category category = await _db.Categories.FindAsync(id);

            return _mapper.Map<CategoryDto>(category);
        }      


    }
}
