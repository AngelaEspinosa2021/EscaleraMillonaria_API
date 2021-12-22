using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public interface IQuestionRepository
    {
        Task<List<QuestionDto>> GetQuestions();
    }
}
