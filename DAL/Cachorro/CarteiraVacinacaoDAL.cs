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
    public class CarteiraVacinacaoDAL : BaseDAL<CarteiraVacinacaoModel>
    {
        private ConexaoDAO conexao;

        public CarteiraVacinacaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM CarteiraVacinacao WHERE IdCarteiraVacinacao = @id");

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

        internal override List<CarteiraVacinacaoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdCarteiraVacinacao, IdCachorro, DataEmissao FROM CarteiraVacinacao");
                List<CarteiraVacinacaoModel> retorno = new List<CarteiraVacinacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraVacinacaoModel carteiraVacinacao = new CarteiraVacinacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraVacinacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraVacinacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraVacinacao.IdCachorro);

                        retorno.Add(carteiraVacinacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CarteiraVacinacaoModel> GetByExample(CarteiraVacinacaoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT IdCarteiraVacinacao, IdCachorro, DataEmissao FROM CarteiraVacinacao WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.Append("AND IdCarteiraVacinacao = @IdCarteira");
                }

                if (obj.IdCachorro > 0)
                {
                    query.Append("AND IdCachorro = @IdCachorro");
                }

                if (string.IsNullOrEmpty(obj.DataEmissao))
                {
                    query.Append("AND DataEmissao = '@DataEmissao'");
                }

                List<CarteiraVacinacaoModel> retorno = new List<CarteiraVacinacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraVacinacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@DataEmissao", obj.DataEmissao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraVacinacaoModel carteiraVacinacao = new CarteiraVacinacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraVacinacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraVacinacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraVacinacao.IdCachorro);

                        retorno.Add(carteiraVacinacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CarteiraVacinacaoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdCarteiraVacinacao, IdCachorro, DataEmissao
                    FROM CarteiraVacinacao
                    WHERE IdCarteiraVacinacao = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraVacinacao", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CarteiraVacinacaoModel carteiraVacinacao = new CarteiraVacinacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraVacinacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraVacinacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraVacinacao.IdCachorro);

                        return carteiraVacinacao;
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

        internal override bool Insert(CarteiraVacinacaoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO CarteiraVacinacao (IdCarteiraVacinacao, IdCachorro, DataEmissao) 
                    VALUES(@IdCarteiraVacinacao, @IdCachorro, '@DataEmissao')"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraVacinacao", obj.IdCarteira);
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

        internal override bool Update(CarteiraVacinacaoModel obj)
        {
            return false;
        }
    }
}
