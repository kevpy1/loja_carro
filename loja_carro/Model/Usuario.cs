using System;

namespace loja_carro.Model
{
    internal class Usuario
    {
        public int Codusuario { get; set; }
        public string Usuarionome { get; set; }
        public string Senha { get; set; }

        public Usuario(int codusuario, string usuarionome, string senha)
        {
            Codusuario = codusuario;
            Usuarionome = usuarionome;
            Senha = senha;
        }

        public Usuario(string usuarionome, string senha)
        {
            Usuarionome = usuarionome;
            Senha = senha;
        }
    }
}
