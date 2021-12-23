using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public interface IAwardRepository
    {
        Task<List<AwardDto>> GetAwards();

        Task<AwardDto> assignAward(int idCategory, int position);
    }
}
