using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Contexto _dbContext;

        // TESTE COMMIT
        public UsuarioRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UsuarioModel>> GetAll()
        {
            return await _dbContext.Usuario.ToListAsync();
        }

        public async Task<UsuarioModel> GetById(int id)
        {
            return await _dbContext.Usuario.FirstOrDefaultAsync(x => x.UsuarioId == id);
        }

        public async Task<UsuarioModel> InsertUsuario(UsuarioModel usuario)
        {
            await _dbContext.Usuario.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<UsuarioModel> UpdateUsuario(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarios = await GetById(id);
            if (usuarios == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                usuarios.NomeUsuario = usuario.NomeUsuario;
                usuarios.IdadeUsuario = usuario.IdadeUsuario;
                usuarios.TipoSexoId = usuario.TipoSexoId;
                usuarios.CpfUsuario = usuario.CpfUsuario;
                usuarios.EnderecoUsuario = usuario.EnderecoUsuario;
                usuarios.TelefoneUsuario = usuario.TelefoneUsuario;
                usuarios.TipoUsuarioId = usuario.TipoUsuarioId;
                usuarios.PlanoId = usuario.PlanoId;
                usuarios.EmailUsuario = usuario.EmailUsuario;
                usuarios.SenhaUsuario = usuario.SenhaUsuario;
                usuarios.ConfirmarSenhaUsuario = usuario.ConfirmarSenhaUsuario;
                _dbContext.Usuario.Update(usuarios);
                await _dbContext.SaveChangesAsync();
            }
            return usuarios;

        }
        public async Task<bool> DeleteUsuario(int id)
        {
            UsuarioModel usuarios = await GetById(id);
            if (usuarios == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Usuario.Remove(usuarios);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
