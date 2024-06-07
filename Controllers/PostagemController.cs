using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostagemController : ControllerBase
    {
        private readonly IPostagemRepositorio _postsRepositorio;

        public PostagemController(IPostagemRepositorio postsRepositorio)
        {
            _postsRepositorio = postsRepositorio;
        }

        [HttpGet("GetAllPostagem")]
        public async Task<ActionResult<List<PostagemModel>>> GetAllPostagem()
        {
            List<PostagemModel> posts = await _postsRepositorio.GetAll();
            return Ok(posts);
        }

        [HttpGet("GetPostagemId/{id}")]
        public async Task<ActionResult<PostagemModel>> GetPostagemId(int id)
        {
            PostagemModel posts = await _postsRepositorio.GetById(id);
            return Ok(posts);
        }

        [HttpPost("CreatePostagem")]
        public async Task<ActionResult<PostagemModel>> InsertPostagem([FromBody] PostagemModel postModel)
        {
            PostagemModel post = await _postsRepositorio.InsertPostagem(postModel);
            return Ok(post);
        }

        [HttpPut("UpdatePostagem/{id:int}")]

        public async Task<ActionResult<PostagemModel>> UpdatePostagem(int id, [FromBody] PostagemModel postModel)
        {
            postModel.PostagemId = id;
            PostagemModel posts = await _postsRepositorio.UpdatePostagem(postModel, id);
            return Ok(posts);
        }
        [HttpDelete("DeletePostagem/{id:int}")]

        public async Task<ActionResult<PostagemModel>> DeletePostagem(int id)
        {
            bool deleted = await _postsRepositorio.DeletePostagem(id);
            return Ok(deleted);
        }
    }
}
