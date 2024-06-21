using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class DadosInfluencerRepositorio : IDadosInfluencerRepositorio
    {
        private readonly Contexto _dbContext;

        public DadosInfluencerRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DadosInfluencerModel>> GetAll()
        {
            return await _dbContext.DadosInfluencer.ToListAsync();
        }

        public async Task<DadosInfluencerModel> GetById(int id)
        {
            return await _dbContext.DadosInfluencer.FirstOrDefaultAsync(x => x.DadosInfluencerId == id);
        }

        public async Task<DadosInfluencerModel> InsertDadosInfluencer(DadosInfluencerModel dadosinfluencer)
        {
            await _dbContext.DadosInfluencer.AddAsync(dadosinfluencer);
            await _dbContext.SaveChangesAsync();
            return dadosinfluencer;
        }

        public async Task<DadosInfluencerModel> UpdateDadosInfluencer(DadosInfluencerModel dadosinfluencer, int id)
        {
            DadosInfluencerModel dadosinfluencers = await GetById(id);
            if (dadosinfluencers == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                dadosinfluencers.UsuarioId = dadosinfluencer.UsuarioId;
                dadosinfluencers.TipoConteudoId = dadosinfluencer.TipoConteudoId;
                dadosinfluencers.TipoRedeSocialId = dadosinfluencer.TipoRedeSocialId;
                dadosinfluencers.DadosInfluencerSeguidores = dadosinfluencer.DadosInfluencerSeguidores;
                await _dbContext.SaveChangesAsync();
            }
            return dadosinfluencers;

        }

        public async Task<bool> DeleteDadosInfluencer(int id)
        {
            DadosInfluencerModel dadosinfluencers = await GetById(id);
            if (dadosinfluencers == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.DadosInfluencer.Remove(dadosinfluencers);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
