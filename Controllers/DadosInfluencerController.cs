using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosInfluencerController : ControllerBase
    {
        private readonly IDadosInfluencerRepositorio _dadosinfluencersRepositorio;

        public DadosInfluencerController(IDadosInfluencerRepositorio dadosinfluencersRepositorio)
        {
            _dadosinfluencersRepositorio = dadosinfluencersRepositorio;
        }

        [HttpGet("GetAllDadosInfluencers")]
        public async Task<ActionResult<List<DadosInfluencerModel>>> GetAllDadosInfluencer()
        {
            List<DadosInfluencerModel> dadosinfluencers = await _dadosinfluencersRepositorio.GetAll();
            return Ok(dadosinfluencers);
        }

        [HttpGet("GetDadosInfluencerId/{id}")]
        public async Task<ActionResult<DadosInfluencerModel>> GetDadosInfluencerId(int id)
        {
            DadosInfluencerModel dadosinfluencer = await _dadosinfluencersRepositorio.GetById(id);
            return Ok(dadosinfluencer);
        }

        [HttpPost("CreateDadosInfluencer")]
        public async Task<ActionResult<DadosInfluencerModel>> InsertInfluencer([FromBody] DadosInfluencerModel dadosinfluencerModel)
        {
            DadosInfluencerModel dadosinfluencer = await _dadosinfluencersRepositorio.InsertDadosInfluencer(dadosinfluencerModel);
            return Ok(dadosinfluencer);
        }

        [HttpPut("UpdateDadosInfluencer/{id:int}")]
        public async Task<ActionResult<DadosInfluencerModel>> UpdateDadosInfluencer(int id, [FromBody] DadosInfluencerModel dadosinfluencerModel)
        {
            dadosinfluencerModel.DadosInfluencerId = id;
            DadosInfluencerModel dadosinfluencer = await _dadosinfluencersRepositorio.UpdateDadosInfluencer(dadosinfluencerModel, id);
            return Ok(dadosinfluencer);
        }

        [HttpDelete("DeleteDadosInfluencer/{id:int}")]
        public async Task<ActionResult<DadosInfluencerModel>> DeleteDadosInfluencer(int id)
        {
            bool deleted = await _dadosinfluencersRepositorio.DeleteDadosInfluencer(id);
            return Ok(deleted);
        }
    }
}
