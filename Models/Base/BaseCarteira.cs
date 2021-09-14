using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.Base
{
    public class BaseCarteira
    {
        public int IdCarteira { get; set; }
        public int IdCachorro { get; set; }
        public string DataEmissao { get; set; }
        public CachorroModel Cachorro { get; set; }
    }
}
