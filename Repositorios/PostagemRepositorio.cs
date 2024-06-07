using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Api.Repositorios
{
    public class PostagemRepositorio : IPostagemRepositorio
    {
        private readonly Contexto _dbContext;

        public PostagemRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PostagemModel>> GetAll()
        {
            return await _dbContext.Postagem.ToListAsync();
        }

        public async Task<PostagemModel> GetById(int id)
        {
            return await _dbContext.Postagem.FirstOrDefaultAsync(x => x.PostagemId == id);
        }

        public async Task<PostagemModel> InsertPostagem(PostagemModel post)
        {
            await _dbContext.Postagem.AddAsync(post);
            await _dbContext.SaveChangesAsync();
            return post;
        }

        public async Task<PostagemModel> UpdatePostagem(PostagemModel post, int id)
        {
            PostagemModel posts = await GetById(id);
            if (posts == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                posts.UsuarioId = posts.UsuarioId;
                posts.TipoRedeSocialId = posts.TipoRedeSocialId;
                posts.TipoConteudoId = posts.TipoConteudoId;
                posts.LikePostagem = posts.LikePostagem;
                posts.DeslikePostagem = posts.DeslikePostagem;
                posts.CompartilhamentoPostagem = posts.CompartilhamentoPostagem;
                posts.SalvosPostagem = posts.SalvosPostagem;
                posts.QuantidadeComentariosPostagem = posts.QuantidadeComentariosPostagem;
                _dbContext.Postagem.Update(posts);
                await _dbContext.SaveChangesAsync();
            }
            return posts;

        }

        public async Task<bool> DeletePostagem(int id)
        {
            PostagemModel posts = await GetById(id);
            if (posts == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Postagem.Remove(posts);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
