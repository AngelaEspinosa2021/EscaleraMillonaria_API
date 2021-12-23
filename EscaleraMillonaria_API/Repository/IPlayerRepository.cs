using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Repository
{
    public interface IPlayerRepository
    {
        Task<List<PlayerDto>> GetPlayers();

        Task<PlayerDto> GetPlayerById(int id);

        Task<PlayerDto> CreatePlayer(PlayerDto playerDto);

        Task<bool> DeletePlayer(int id);
    }
}
