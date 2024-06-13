using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IPostagemRepositorio 
    {
        Task<List<PostagemModel>> GetAll();

        Task<PostagemModel> GetById(int id);

        Task<PostagemModel> InsertPostagem(PostagemModel post);

        Task<PostagemModel> UpdatePostagem(PostagemModel post, int id);

        Task<bool> DeletePostagem(int id);
    }
}
