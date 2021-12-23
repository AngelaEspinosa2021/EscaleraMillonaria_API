using AutoMapper;
using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models;
using EscaleraMillonaria_API.Models.Dto;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<QuestionDto>> GetQuestionsByCategory(int idCategory)
        {
            List<Question> allQuestions = await _db.Questions.ToListAsync();
            List<Question> finalList = new List<Question>();
            var listTemp = new List<Question>();

            foreach (var question in allQuestions)
            {
                var temp = (from m in allQuestions
                            where m.IdCategory == idCategory
                            select m);

                if (temp.Count() > 0)
                {
                    listTemp = temp.ToList();
                }
            }

            foreach (var list in listTemp)
            {
                finalList.Add(list);
            }

            return _mapper.Map<List<QuestionDto>>(finalList.OrderBy(arg => Guid.NewGuid()).Take(6));
        }

        public async Task<bool> validateQuestions(string answer, int idQuestion)
        {
            try
            {
                var question = await _db.Questions.FindAsync(idQuestion);
                var answerInt = Convert.ToInt32(answer);
                var answerQuestion = Convert.ToInt32(question.Answer);
                if (question == null)
                {
                    return false;
                }
                
                if(answerInt == answerQuestion)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
