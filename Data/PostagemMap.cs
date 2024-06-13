using Microsoft.EntityFrameworkCore;
using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class PostagemMap : IEntityTypeConfiguration<PostagemModel>
    {
        public void Configure(EntityTypeBuilder<PostagemModel> builder)
        {
            builder.HasKey(x => x.PostagemId);
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.TipoRedeSocialId).IsRequired();
            builder.Property(x => x.TipoConteudoId).IsRequired();
            builder.Property(x => x.LikePostagem).IsRequired();
            builder.Property(x => x.DeslikePostagem).IsRequired();
            builder.Property(x => x.CompartilhamentoPostagem).IsRequired();
            builder.Property(x => x.SalvosPostagem).IsRequired();
            builder.Property(x => x.QuantidadeComentariosPostagem).IsRequired();
            
        }
    }
}
