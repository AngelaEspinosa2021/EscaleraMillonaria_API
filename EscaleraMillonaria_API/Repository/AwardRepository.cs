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
    public class AwardRepository : IAwardRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public AwardRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<AwardDto> assignAward(int idCategory, int position)
        {
            List<Award> allAwards = await _db.Awards.ToListAsync();
            Award awardWon = new Award();

            foreach (var award in allAwards)
            {
                int numPosition = Int32.Parse(award.QuestionPosition);
                var temp = (from m in allAwards
                            where m.IdCategory == idCategory && numPosition == position
                            select m.AwardValue);

                if(temp.Count() > 0)
                {
                    awardWon = (Award)temp;
                }
            }

            return _mapper.Map<AwardDto>(awardWon);
            
        }

        public async Task<List<AwardDto>> GetAwards()
        {
            List<Award> list = await _db.Awards.ToListAsync();

            return _mapper.Map<List<AwardDto>>(list);
        }
    }
}
