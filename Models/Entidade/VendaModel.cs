using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Entidade
{
    public class VendaModel
    {
        public int IdVenda { get; set; }
        public int IdCachorro { get; set; }
        public int IdComprador { get; set; }
        public string DataCompra { get; set; }
        public string DataReserva { get; set; }
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public string NotaFiscal { get; set; }
        public CachorroModel Cachorro { get; set; }
        public CompradorModel Comprador { get; set; }
    }
}
