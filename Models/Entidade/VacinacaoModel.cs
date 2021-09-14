using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class VacinacaoModel
    {
        public int IdVacinacao { get; set; }
        public int IdCarteira { get; set; }
        public int IdVacina { get; set; }
        public string DataAplicacao { get; set; }
        public int IdVeterinario { get; set; }
        public decimal Dose { get; set; }
        public string Observacao { get; set; }
        public CarteiraVacinacaoModel CarteiraVacinacao { get; set; }
        public VacinaModel Vacina { get; set; }
        public VeterinarioModel Veterinario { get; set; }
    }
}
