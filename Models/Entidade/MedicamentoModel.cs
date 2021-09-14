using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class MedicamentoModel
    {
        public int IdMedicamento { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Composicao { get; set; }
    }
}
