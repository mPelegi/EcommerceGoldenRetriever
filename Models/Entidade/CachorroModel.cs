using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class CachorroModel
    {
        public int IdCachorro { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Porte { get; set; } = "";
        public string DataNascimento { get; set; } = "";
        public string Raca { get; set; } = "";
        public string Sexo { get; set; } = "";
        public int Pedigree { get; set; } = 0;
        public int IdMatriz { get; set; } = 0;
        public int IdPadreador { get; set; } = 0;
        public int IdDono { get; set; } = 0;
        public bool? Reservado { get; set; } = false;
        public int IdComprador { get; set; } = 0;
        public CachorroModel Matriz { get; set; }
        public CachorroModel Padreador { get; set; }
        public DonoModel Dono { get; set; }
        public CompradorModel Comprador { get; set; }

    }
}
