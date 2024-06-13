using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class DadosInfluencerMap : IEntityTypeConfiguration<DadosInfluencerModel>
    {
        public void Configure(EntityTypeBuilder<DadosInfluencerModel> builder)
        {
            builder.HasKey(x => x.DadosInfluencerId);
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.TipoConteudoId).IsRequired();
            builder.Property(x => x.TipoRedeSocialId).IsRequired();
            builder.Property(x => x.DadosInfluencerSeguidores).IsRequired();
        }
    }
}
