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

        public async Task<CategoryDto> GetQuestionsByCategory(int idCategory)
        {
            Category category = new Category();
            List<Question> listTemp = new List<Question>();
            var list = new List<Question>();

            //var temp = (from m in _db.Categories
            //            join p in _db.Questions on m.IdCategory=p.
            //            select m);

            if(temp.Count() > 0)
            {
                list = temp.ToList();
            }

            
            foreach(var question in list)
            {
                listTemp.Add(question);
            }
            
            foreach(var question in listTemp)
            {
                category.Questions.Add(question);
            }
                        
                 
            return _mapper.Map<CategoryDto>(category);
        }

    }
}
