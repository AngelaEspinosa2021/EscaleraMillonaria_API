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
            return await _context.Awards.ToListAsync();
        }

        private bool AwardExists(int id)
        {
            return _context.Awards.Any(e => e.IdAward == id);
        }
    }
}
