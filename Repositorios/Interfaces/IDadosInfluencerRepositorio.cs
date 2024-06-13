using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IDadosInfluencerRepositorio
    {
        Task<List<DadosInfluencerModel>> GetAll();

        Task<DadosInfluencerModel> GetById(int id);

        Task<DadosInfluencerModel> InsertDadosInfluencer(DadosInfluencerModel dadosinfluencer);

        Task<DadosInfluencerModel> UpdateDadosInfluencer(DadosInfluencerModel dadosinfluencer, int id);

        Task<bool> DeleteDadosInfluencer(int id);
    }
}
