using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EscaleraMillonaria_API.Data;
using EscaleraMillonaria_API.Models;
using EscaleraMillonaria_API.Repository;
using EscaleraMillonaria_API.Models.Dto;

namespace EscaleraMillonaria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        protected ResponseDto _response;

        public PlayersController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
            _response = new ResponseDto();
        }

        // GET: api/Players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            try
            {
                var list = await _playerRepository.GetPlayers();
                _response.Result = list;
                _response.DisplayMessage = "Lista de Jugadores Inscritos";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }
            return Ok(_response);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _playerRepository.GetPlayerById(id);
            if (player == null)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "Jugador no Existe";
                return NotFound(_response);
            }
            _response.Result = player;
            _response.DisplayMessage = "Información del Jugador";
            return Ok(player);
        }

        // PUT: api/Players/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer(PlayerDto playerDto)
        {
            try
            {
                PlayerDto model = await _playerRepository.CreateUpdatePlayer(playerDto);
                _response.Result = model;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "Error al actualizar el registor";
                _response.ErrorMessage = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }
        }

        // POST: api/Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Player>> PostCustomer(PlayerDto playerDto)
        {
            try
            {
                PlayerDto model = await _playerRepository.CreateUpdatePlayer(playerDto);
                _response.Result = model;
                return CreatedAtAction("GetPlayerById", new { id = model.IdPlayer }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "Error al Grabar el Registro";
                _response.ErrorMessage = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Player>> DeletePlayer(int id)
        {
            try
            {
                bool isEliminated = await _playerRepository.DeletePlayer(id);
                if(isEliminated)
                {
                    _response.Result = isEliminated;
                    _response.DisplayMessage = "Jugador Eliminado con Exito.";
                    return Ok(_response);
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.DisplayMessage = "Error al Eliminar Jugador.";
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }
        }        
    }
}
