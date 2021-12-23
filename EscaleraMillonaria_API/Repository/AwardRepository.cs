using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public class AwardRepository : IAwardRepository
    {
        public Task<AwardDto> assignAward(int idCategory, int position)
        {
            throw new NotImplementedException();
        }

        public Task<List<AwardDto>> GetAwards()
        {
            throw new NotImplementedException();
        }
    }
}
