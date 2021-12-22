using AutoMapper;
using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models;
using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public QuestionRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<List<QuestionDto>> GetQuestions()
        {
            throw new NotImplementedException();
        }

        //private List<Question> getQuestionsByCategory(int idCategory)
        //{
        //    var listQuestions = _db.Questions.Include(p => p.)
        //}

        //public Task<List<QuestionDto>> GetQuestions()
        //{
        //    List<Question> questionsCategoryOne = new List<Question>();
        //    List<Question> questionsCategoryTwo = new List<Question>();
        //    List<Question> questionsCategoryThree = new List<Question>();
        //    List<Question> questionsCategoryFour = new List<Question>();
        //    List<Question> questionsCategoryFive = new List<Question>();
        //    var listTemp = new List<Question>();

        //    var listCategoryOne = from m in _db.Questions
        //                          where m.IdQuestion > 9 && m.IdQuestion < 21
        //                          select m;



        //    return _mapper.Map<List<QuestionDto>>(questionsCategoryOne);

        //}
    }
}
