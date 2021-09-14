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
    public class CarteiraExameDAL : BaseDAL<CarteiraExameModel>
    {
        private ConexaoDAO conexao;

        public CarteiraExameDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM CarteiraExame WHERE IdCarteiraExame = @id");

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

        internal override List<CarteiraExameModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdCarteiraExame, IdCachorro, DataEmissao FROM CarteiraExame");
                List<CarteiraExameModel> retorno = new List<CarteiraExameModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraExameModel carteiraExame = new CarteiraExameModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraExame"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraExame.Cachorro = new CachorroBLL().ObterPeloId(carteiraExame.IdCachorro);

                        retorno.Add(carteiraExame);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CarteiraExameModel> GetByExample(CarteiraExameModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT IdCarteiraExame, IdCachorro, DataEmissao FROM CarteiraExame WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.Append("AND IdCarteiraExame = @IdCarteira");
                }

                if (obj.IdCachorro > 0)
                {
                    query.Append("AND IdCachorro = @IdCachorro");
                }

                if (string.IsNullOrEmpty(obj.DataEmissao))
                {
                    query.Append("AND DataEmissao = '@DataEmissao'");
                }

                List<CarteiraExameModel> retorno = new List<CarteiraExameModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraExame", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@DataEmissao", obj.DataEmissao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CarteiraExameModel carteiraExame = new CarteiraExameModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraExame"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraExame.Cachorro = new CachorroBLL().ObterPeloId(carteiraExame.IdCachorro);

                        retorno.Add(carteiraExame);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CarteiraExameModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdCarteiraExame, IdCachorro, DataEmissao
                    FROM CarteiraExame
                    WHERE IdCarteiraExame = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraExame", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CarteiraExameModel carteiraExame = new CarteiraExameModel
                        {
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraExame"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            DataEmissao = dataReader["DataEmissao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataEmissao"]),
                        };
                        carteiraExame.Cachorro = new CachorroBLL().ObterPeloId(carteiraExame.IdCachorro);

                        return carteiraExame;
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

        internal override bool Insert(CarteiraExameModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO CarteiraExame (IdCarteiraExame, IdCachorro, DataEmissao) 
                    VALUES(@IdCarteiraExame, @IdCachorro, '@DataEmissao'"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraExame", obj.IdCarteira);
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

        internal override bool Update(CarteiraExameModel obj)
        {
            return false;
        }
    }
}
