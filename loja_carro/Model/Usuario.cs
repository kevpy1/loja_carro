using loja_carro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_carro.Model
{
    
    internal class Usuario
    {
        public int Codusuario { get; set; }
        public string Usuarionome { get; set; }
        public string Senha { get; set; }
        
        public Usuario( int codusuario , string usuario, string senha)
        {
            Codusuario = codusuario;
           

        }
    

      public Usuario(string usuario, string senha)
{
    Codusuario = Codusuario;
    Usuarionome = usuario;
    Senha = senha;

}
    }
}       