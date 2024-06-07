namespace Api.Models
{
    public class PostagemModel
    {
        public int PostagemId { get; set; }

        public int UsuarioId { get; set; }

        public int TipoRedeSocialId { get; set; }

        public int TipoConteudoId { get; set; }

        public int LikePostagem { get; set; }

        public int DeslikePostagem { get; set; }

        public int CompartilhamentoPostagem { get; set; }

        public int SalvosPostagem { get; set; }

        public int QuantidadeComentariosPostagem { get; set; }


    }
}
