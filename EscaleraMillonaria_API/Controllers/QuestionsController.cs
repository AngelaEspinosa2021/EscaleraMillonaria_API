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
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
        {
            return await _context.Questions.ToListAsync();
        }

        // GET: api/Questions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(int id)
        {
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            return question;
        }       

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.IdQuestion == id);
        }
    }
}
