using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_carro.Resources.Model
{
    internal class Cliente
    {
        public int codlojacarro { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
      

        public Cliente(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}

