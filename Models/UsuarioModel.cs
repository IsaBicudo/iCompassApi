namespace Api.Models
{
    public class UsuarioModel
    {
        public int UsuarioId { get; set; }

        public string NomeUsuario { get; set; } = string.Empty;

        public int IdadeUsuario { get; set; } 

        public int TipoSexoId { get; set; } 

        public int CpfUsuario { get; set; }

        public string EnderecoUsuario { get; set; } = string.Empty;

        public int TelefoneUsuario { get; set; }

        public int TipoUsuarioId { get; set; }

        public int PlanoId { get; set; }

        public string EmailUsuario { get; set; } = string.Empty;

        public string SenhaUsuario { get; set; } = string.Empty;

        public string ConfirmarSenhaUsuario { get; set; } = string.Empty;

        public string BiografiaUsuario { get; set; } = string.Empty;

        public string FotoUsuario { get; set; } = string.Empty;
        public int DadosInfluencerId { get; internal set; }

        public static implicit operator List<object>(UsuarioModel v)
        {
            throw new NotImplementedException();
        }
    }
}
