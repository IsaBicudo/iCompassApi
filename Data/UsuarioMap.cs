using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.UsuarioId);
            builder.Property(x => x.NomeUsuario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.IdadeUsuario).IsRequired();
            builder.Property(x => x.TipoSexoId).IsRequired();
            builder.Property(x => x.CpfUsuario).IsRequired();
            builder.Property(x => x.EnderecoUsuario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TelefoneUsuario).IsRequired();
            builder.Property(x => x.TipoUsuarioId).IsRequired();
            builder.Property(x => x.PlanoId).IsRequired();
            builder.Property(x => x.EmailUsuario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.SenhaUsuario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ConfirmarSenhaUsuario).IsRequired().HasMaxLength(255);
        }
    }
}
