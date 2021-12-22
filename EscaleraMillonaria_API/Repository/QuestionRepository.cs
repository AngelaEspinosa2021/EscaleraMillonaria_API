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
        public Task<List<QuestionDto>> GetQuestions()
        {
            List<Question> questionsCategoryOne = new List<Question>();
            List<Question> questionsCategoryTwo = new List<Question>();
            List<Question> questionsCategoryThree = new List<Question>();
            List<Question> questionsCategoryFour = new List<Question>();
            List<Question> questionsCategoryFive = new List<Question>();
        }
    }
}
