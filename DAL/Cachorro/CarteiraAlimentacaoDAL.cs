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
    public class CarteiraAlimentacaoDAL : BaseDAL<CarteiraAlimentacaoModel>
    {
        private ConexaoDAO conexao;

        public CarteiraAlimentacaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM CarteiraAlimentacao WHERE IdCarteiraAlimentacao = @id");

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

        internal override List<CarteiraAlimentacaoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdCarteiraAlimentacao, IdCachorro, DataEmissao FROM CarteiraAlimentacao");
                List<CarteiraAlimentacaoModel> retorno = new List<CarteiraAlimentacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraAlimentacaoModel carteiraAlimentacao = new CarteiraAlimentacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraAlimentacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraAlimentacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraAlimentacao.IdCachorro);

                        retorno.Add(carteiraAlimentacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CarteiraAlimentacaoModel> GetByExample(CarteiraAlimentacaoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT IdCarteiraAlimentacao, IdCachorro, DataEmissao FROM CarteiraAlimentacao WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.Append("AND IdCarteiraAlimentacao = @IdCarteira");
                }

                if (obj.IdCachorro > 0)
                {
                    query.Append("AND IdCachorro = @IdCachorro");
                }

                if (string.IsNullOrEmpty(obj.DataEmissao))
                {
                    query.Append("AND DataEmissao = '@DataEmissao'");
                }

                List<CarteiraAlimentacaoModel> retorno = new List<CarteiraAlimentacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraAlimentacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@DataEmissao", obj.DataEmissao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraAlimentacaoModel carteiraAlimentacao = new CarteiraAlimentacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraAlimentacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraAlimentacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraAlimentacao.IdCachorro);

                        retorno.Add(carteiraAlimentacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CarteiraAlimentacaoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdCarteiraAlimentacao, IdCachorro, DataEmissao
                    FROM CarteiraAlimentacao
                    WHERE IdCarteiraAlimentacao = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraAlimentacao", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CarteiraAlimentacaoModel carteiraAlimentacao = new CarteiraAlimentacaoModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraAlimentacao"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraAlimentacao.Cachorro = new CachorroBLL().ObterPeloId(carteiraAlimentacao.IdCachorro);

                        return carteiraAlimentacao;
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

        internal override bool Insert(CarteiraAlimentacaoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO CarteiraAlimentacao (IdCarteiraAlimentacao, IdCachorro, DataEmissao) 
                    VALUES(@IdCarteiraAlimentacao, @IdCachorro, '@DataEmissao'"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraAlimentacao", obj.IdCarteira);
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

        internal override bool Update(CarteiraAlimentacaoModel obj)
        {
            return false;
        }
    }
}
