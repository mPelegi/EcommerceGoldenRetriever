using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class AlimentoModel
    {
        public int IdAlimento { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Composicao { get; set; }
    }
}
