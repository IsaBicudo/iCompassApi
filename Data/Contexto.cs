using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<PostagemModel> Postagem { get; set; }
        public DbSet<DadosInfluencerModel> DadosInfluencer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new DadosInfluencerMap());
            modelBuilder.ApplyConfiguration(new PostagemMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
