using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class MedicacaoModel
    {
        public int IdMedicacao { get; set; }
        public int IdCarteira { get; set; }
        public int IdMedicamento { get; set; }
        public string DataInicio { get; set; }
        public string DataTermino { get; set; }
        public int IdVeterinario { get; set; }
        public decimal Posologia { get; set; }
        public string Justificativa { get; set; }
        public CarteiraMedicacaoModel CarteiraMedicacao { get; set; }
        public MedicamentoModel Medicamento { get; set; }
        public VeterinarioModel Veterinario { get; set; }
    }
}
