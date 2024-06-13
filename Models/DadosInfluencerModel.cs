namespace Api.Models
{
    public class DadosInfluencerModel
    {
        public int DadosInfluencerId { get; set; }

        public int UsuarioId { get; set; } 

        public int TipoConteudoId { get; set; } 

        public int TipoRedeSocialId { get; set; }
        public string DadosInfluencerSeguidores { get; set; } = string.Empty;

        public static implicit operator List<object>(DadosInfluencerModel v)
        {
            throw new NotImplementedException();
        }
    }
}
