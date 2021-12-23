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
    public class AwardRepository : IAwardRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public AwardRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<AwardDto> assignAward(int idCategory, int position)
        {
            throw new NotImplementedException();
        }

        //public async Task<List<AwardDto>> GetAwards()
        //{
        //    List<Award> list = await _db.Awards.
    }
}
