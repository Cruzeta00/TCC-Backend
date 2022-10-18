using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.BancoDeDados;
using TCC.Modelos;

namespace TCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var contexto = new ContextoBD())
            {
                contexto.Usuarios.Add(new Usuario { NomeId = 0, Nome = "Julio", Celular = "11949660544", Email = "julio.email@gmail.com", Senha = "mudar123", Id = "abc" });
                contexto.SaveChanges();

                foreach(var usuario in contexto.Usuarios)
                {
                    Console.WriteLine(usuario.Nome);
                    Console.WriteLine(usuario.Celular);
                }
            }
            Console.WriteLine("Aperte para sair...");
            Console.ReadLine();
        }
    }
}
