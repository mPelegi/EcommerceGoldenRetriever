using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class AlimentacaoModel
    {
        public int IdAlimentacao { get; set; }
        public int IdCarteira { get; set; }
        public int IdAlimento { get; set; }
        public string DataInicio { get; set; }
        public string DataTermino { get; set; }
        public int IdVeterinario { get; set; }
        public int FrequenciaDiaria { get; set; }
        public decimal Quantidade { get; set; }
        public CarteiraAlimentacaoModel CarteiraAlimentacao { get; set; }
        public AlimentoModel Alimento { get; set; }
        public VeterinarioModel Veterinario { get; set; }
    }
}
