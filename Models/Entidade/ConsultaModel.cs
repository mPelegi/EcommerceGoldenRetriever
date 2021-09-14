using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class ConsultaModel
    {
        public int IdConsulta { get; set; }
        public int IdCarteira { get; set; }
        public int IdExame { get; set; }
        public string DataExame { get; set; }
        public int IdVeterinario { get; set; }
        public string Resultado { get; set; }
        public string Observacao { get; set; }
        public CarteiraExameModel CarteiraExame { get; set; }
        public ExameModel Exame { get; set; }
        public VeterinarioModel Veterinario { get; set; }
    }
}
