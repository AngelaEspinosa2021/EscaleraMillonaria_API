using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models;
using EscaleraMillonaria_API.Repository;
using EscaleraMillonaria_API.Models.Dto;

namespace EscaleraMillonaria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        protected ResponseDto _response;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _response = new ResponseDto();
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            try
            {
                var list = await _categoryRepository.GetCategories();
                _response.Result = list;
                _response.DisplayMessage = "Lista de Categorias";
            }
            catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return Ok(_response);

        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _categoryRepository.GetCategoryById(id);
            if (category == null)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "La Categoria no Existe";
                return NotFound(_response);
            }
            _response.Result = category;
            _response.DisplayMessage = "Información de la Categoria";
            return Ok(category);
        }

    }
}
