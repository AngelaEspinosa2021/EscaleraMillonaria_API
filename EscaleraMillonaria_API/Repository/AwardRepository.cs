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

        public async Task<List<AwardDto>> assignAward(int idCategory, int position)
        {
            List<Award> allAwards = await _db.Awards.ToListAsync();
            List<Award> awardWon = new List<Award>();
            var listTemp = new List<Award>();

            foreach (var award in allAwards)
            {
                var temp = (from m in allAwards
                            where m.IdCategory == idCategory && m.QuestionPosition == position
                            select m);

                if(temp.Count() > 0)
                {
                    listTemp = temp.ToList();
                }
            }
            
            foreach (var list in listTemp)
            {
                awardWon.Add(list);
            }

            return _mapper.Map<List<AwardDto>>(awardWon);
            
        }

        public async Task<List<AwardDto>> GetAwards()
        {
            List<Award> list = await _db.Awards.ToListAsync();

            return _mapper.Map<List<AwardDto>>(list);
        }
    }
}
