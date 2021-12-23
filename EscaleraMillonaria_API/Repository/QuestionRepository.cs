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

            foreach(var question in allQuestions)
            {
                var temp = (from m in allQuestions
                            where m.IdCategory == idCategory
                            select m);

                if(temp.Count() > 0)
                {
                    listTemp = temp.ToList();
                }
            }

            foreach(var list in listTemp)
            {
                finalList.Add(list);
            }


            return _mapper.Map<List<QuestionDto>>(finalList);
        }

    }
}
