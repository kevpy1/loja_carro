using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_carro.Resources.Model
{
    internal class Property
    {
        public int codlojacarro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Preco { get; set; }

        public Property(string marca,string modelo, float preco)
        {
            Marca = marca;
            Modelo = modelo;
            Preco = preco;
        }
    }
}

