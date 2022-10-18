using System.ComponentModel.DataAnnotations;

namespace APIBackEnd.Modelos
{
    public class ModeloLogin
    {
        [Key]
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
}
