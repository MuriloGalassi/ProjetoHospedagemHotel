using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Documento { get; set; }

        public Pessoa(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Documento: {Documento}";
        }
    }
}
