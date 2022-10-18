using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Modelos;

namespace TCC.BancoDeDados
{
    public class ContextoBD : DbContext
    {
        public ContextoBD() : base("TCC")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ContextoBD>());
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
