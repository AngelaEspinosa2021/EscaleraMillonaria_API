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
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;
        protected ResponseDto _response;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
            _response = new ResponseDto();
        }

        // GET: api/Questions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestionsByCategory(int idCategory)
        {
            try
            {
                var list = await _questionRepository.GetQuestionsByCategory(idCategory);
                _response.Result = list;
                _response.DisplayMessage = "Listado de Preguntas";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return Ok(_response);
        }
              
        
    }
}
