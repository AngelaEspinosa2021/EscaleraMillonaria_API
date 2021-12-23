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
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public PlayerRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<PlayerDto> CreateUpdatePlayer(PlayerDto playerDto)
        {
            Player player = _mapper.Map<PlayerDto, Player>(playerDto);
            if(player.IdPlayer > 0)
            {
                _db.Players.Update(player);
            }
            else
            {
                await _db.Players.AddAsync(player);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Player, PlayerDto>(player);
        }

        public async Task<bool> DeletePlayer(int id)
        {
            try
            {
                Player player = await _db.Players.FindAsync(id);
                if(player == null)
                {
                    return false;
                }
                _db.Players.Remove(player);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<PlayerDto> GetPlayerById(int id)
        {
            Player player = await _db.Players.FindAsync(id);

            return _mapper.Map<PlayerDto>(player);
        }

        public async Task<List<PlayerDto>> GetPlayers()
        {
            List<Player> list = await _db.Players.ToListAsync();

            return _mapper.Map<List<PlayerDto>>(list);
        }
    }
}
