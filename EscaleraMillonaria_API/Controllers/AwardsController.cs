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
    public class AwardsController : ControllerBase
    {
        private readonly IAwardRepository _awardRepository;
        protected ResponseDto _response;

        public AwardsController(IAwardRepository awardRepository)
        {
            _awardRepository = awardRepository;
            _response = new ResponseDto();
        }

        // GET: api/Awards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Award>>> GetAwards()
        {
            try
            {
                var list = await _awardRepository.GetAwards();
                _response.Result = list;
                _response.DisplayMessage = "Listado de Premios";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return Ok(_response);
        }

        [HttpGet("{idCategory}/{position}")]

        public async Task<ActionResult<IEnumerable<Award>>> assignAward(int idCategory, int position)
        {
            try
            {
                var list = await _awardRepository.assignAward(idCategory, position);
                _response.Result = list;
                return Ok(list);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return Ok(_response);
        }
    }
}
