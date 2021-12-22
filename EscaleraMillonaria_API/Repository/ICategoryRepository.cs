using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDto>> GetCategories();

        Task<CategoryDto> GetCustomerById(int id);

        Task<List<CategoryDto>> Initialize();
    }
}
