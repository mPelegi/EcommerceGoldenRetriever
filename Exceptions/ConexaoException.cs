using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Exceptions
{
    public class ConexaoException : Exception
    {
        public ConexaoException()
        {

        }

        public ConexaoException(string message)
            : base(message)
        {

        }
    }
}
