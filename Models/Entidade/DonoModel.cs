using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class DonoModel
    {
        public int IdDono { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }
    }
}
