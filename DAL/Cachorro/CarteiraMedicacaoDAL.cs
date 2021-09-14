using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Cachorro
{
    public class CarteiraMedicacaoDAL : BaseDAL<CarteiraMedicacaoModel>
    {
        private ConexaoDAO conexao;

        public CarteiraMedicacaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM CarteiraMedicacao WHERE IdCarteiraMedicacao = @id");

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CarteiraMedicacaoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdCarteiraMedicacao, IdCachorro, DataEmissao FROM CarteiraMedicacao");
                List<CarteiraMedicacaoModel> retorno = new List<CarteiraMedicacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraMedicacaoModel carteiraMedicacao = new CarteiraMedicacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraMedicacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraMedicacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraMedicacao.IdCachorro);

                        retorno.Add(carteiraMedicacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CarteiraMedicacaoModel> GetByExample(CarteiraMedicacaoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT IdCarteiraMedicacao, IdCachorro, DataEmissao FROM CarteiraMedicacao WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.Append("AND IdCarteiraMedicacao = @IdCarteira");
                }

                if (obj.IdCachorro > 0)
                {
                    query.Append("AND IdCachorro = @IdCachorro");
                }

                if (string.IsNullOrEmpty(obj.DataEmissao))
                {
                    query.Append("AND DataEmissao = '@DataEmissao'");
                }

                List<CarteiraMedicacaoModel> retorno = new List<CarteiraMedicacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraMedicacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@DataEmissao", obj.DataEmissao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraMedicacaoModel carteiraMedicacao = new CarteiraMedicacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraMedicacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraMedicacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraMedicacao.IdCachorro);

                        retorno.Add(carteiraMedicacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CarteiraMedicacaoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdCarteiraMedicacao, IdCachorro, DataEmissao
                    FROM CarteiraMedicacao
                    WHERE IdCarteiraMedicacao = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraMedicacao", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CarteiraMedicacaoModel carteiraMedicacao = new CarteiraMedicacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraMedicacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraMedicacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraMedicacao.IdCachorro);

                        return carteiraMedicacao;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Insert(CarteiraMedicacaoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO CarteiraMedicacao (IdCarteiraMedicacao, IdCachorro, DataEmissao) 
                    VALUES(@IdCarteiraMedicacao, @IdCachorro, '@DataEmissao'"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraMedicacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@DataEmissao", obj.DataEmissao);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(CarteiraMedicacaoModel obj)
        {
            return false;
        }
    }
}
