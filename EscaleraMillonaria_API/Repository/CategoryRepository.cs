using AutoMapper;
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
        private IMapper _mapper;

        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
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
