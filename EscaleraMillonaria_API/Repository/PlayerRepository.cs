using AutoMapper;
using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public PlayerRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public Task<PlayerDto> CreatePlayer(PlayerDto playerDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePlayer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDto> GetPlayerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PlayerDto>> GetPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
