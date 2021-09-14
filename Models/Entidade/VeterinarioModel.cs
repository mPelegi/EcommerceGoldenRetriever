using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class VeterinarioModel
    {
        public int IdVeterinario {get; set;}
        public string CRMV { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
    }
}
