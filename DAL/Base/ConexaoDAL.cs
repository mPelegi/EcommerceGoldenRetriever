using System.Data.SqlClient;

namespace EcommerceGoldenRetriever.MVC.DAL.Base
{
    public class ConexaoDAL
    {
        private SqlConnection conexao;

        public ConexaoDAL(SqlConnection conexao)
        {
            this.conexao = conexao;
        }
    }
}
