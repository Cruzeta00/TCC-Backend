using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Modelos
{
    public class Usuario
    {
        public string Id { get; set; }
        public int NomeId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
    }
}
