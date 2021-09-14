using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Registro
{
    public class AlimentacaoDAL : BaseDAL<AlimentacaoModel>
    {
        private ConexaoDAO conexao;

        public AlimentacaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Alimentacao WHERE IdAlimentacao = @id");

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

        internal override List<AlimentacaoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdAlimentacao, IdCarteiraAlimentacao, IdAlimento, DataInicio, DataTermino, IdVeterinario, FrequenciaDiaria, Quantidade FROM Alimentacao");

                List<AlimentacaoModel> retorno = new List<AlimentacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        AlimentacaoModel alimentacao = new AlimentacaoModel
                        {
                            IdAlimentacao = Convert.ToInt32(dataReader["IdAlimentacao"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraAlimentacao"]),
                            IdAlimento = Convert.ToInt32(dataReader["IdAlimento"]),
                            DataInicio = dataReader["DataInicio"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataInicio"]),
                            DataTermino = dataReader["DataTermino"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataTermino"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            FrequenciaDiaria = Convert.ToInt32(dataReader["FrequenciaDiaria"]),
                            Quantidade = Convert.ToDecimal(dataReader["Quantidade"]),
                        };
                        alimentacao.CarteiraAlimentacao = new CarteiraAlimentacaoBLL().ObterPeloId(alimentacao.IdCarteira);
                        alimentacao.Veterinario = new VeterinarioBLL().ObterPeloId(alimentacao.IdVeterinario);

                        retorno.Add(alimentacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<AlimentacaoModel> GetByExample(AlimentacaoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdAlimentacao, IdCarteiraAlimentacao, IdAlimento, DataInicio, DataTermino, IdVeterinario, FrequenciaDiaria, Quantidade FROM Alimentacao WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.AppendLine("AND IdCarteiraAlimentacao = @IdCarteira");
                }

                if (obj.IdAlimento > 0)
                {
                    query.AppendLine("AND IdAlimento = @IdAlimento");
                }

                if (string.IsNullOrEmpty(obj.DataInicio))
                {
                    query.AppendLine("AND DataInicio = '@DataInicio'");
                }

                if (string.IsNullOrEmpty(obj.DataTermino))
                {
                    query.AppendLine("AND DataTermino = '@DataTermino'");
                }

                if (obj.IdVeterinario > 0)
                {
                    query.AppendLine("AND IdVeterinario = @IdVeterinario");
                }

                if (obj.FrequenciaDiaria > 0)
                {
                    query.AppendLine("AND FrequenciaDiaria = @FrequenciaDiaria");
                }

                if (obj.Quantidade > 0)
                {
                    query.AppendLine("AND Quantidade = @Quantidade");
                }

                List<AlimentacaoModel> retorno = new List<AlimentacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraAlimentacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdAlimento", obj.IdAlimento);
                    cmd.Parameters.AddWithValue("@DataInicio", obj.DataInicio);
                    cmd.Parameters.AddWithValue("@DataTermino", obj.DataTermino);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@FrequenciaDiaria", obj.FrequenciaDiaria);
                    cmd.Parameters.AddWithValue("@Quantidade", obj.Quantidade);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        AlimentacaoModel alimentacao = new AlimentacaoModel
                        {
                            IdAlimentacao = Convert.ToInt32(dataReader["IdAlimentacao"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraAlimentacao"]),
                            IdAlimento = Convert.ToInt32(dataReader["IdAlimento"]),
                            DataInicio = dataReader["DataInicio"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataInicio"]),
                            DataTermino = dataReader["DataTermino"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataTermino"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            FrequenciaDiaria = Convert.ToInt32(dataReader["FrequenciaDiaria"]),
                            Quantidade = Convert.ToDecimal(dataReader["Quantidade"]),
                        };
                        alimentacao.CarteiraAlimentacao = new CarteiraAlimentacaoBLL().ObterPeloId(alimentacao.IdCarteira);
                        alimentacao.Veterinario = new VeterinarioBLL().ObterPeloId(alimentacao.IdVeterinario);

                        retorno.Add(alimentacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override AlimentacaoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdAlimentacao, IdCarteiraAlimentacao, IdAlimento, DataAplicacao, IdVeterinario, Dose, Observacao
                    FROM Alimentacao
                    WHERE IdAlimentacao = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraAlimentacao", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        AlimentacaoModel alimentacao = new AlimentacaoModel
                        {
                            IdAlimentacao = Convert.ToInt32(dataReader["IdAlimentacao"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraAlimentacao"]),
                            IdAlimento = Convert.ToInt32(dataReader["IdAlimento"]),
                            DataInicio = dataReader["DataInicio"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataInicio"]),
                            DataTermino = dataReader["DataTermino"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataTermino"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            FrequenciaDiaria = Convert.ToInt32(dataReader["FrequenciaDiaria"]),
                            Quantidade = Convert.ToDecimal(dataReader["Quantidade"]),
                        };
                        alimentacao.CarteiraAlimentacao = new CarteiraAlimentacaoBLL().ObterPeloId(alimentacao.IdCarteira);
                        alimentacao.Veterinario = new VeterinarioBLL().ObterPeloId(alimentacao.IdVeterinario);

                        return alimentacao;
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

        internal override bool Insert(AlimentacaoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO Alimentacao (IdCarteiraAlimentacao, IdAlimento, DataInicio, DataTermino, IdVeterinario, FrequenciaDiaria, Quantidade) 
                    VALUES(@IdCarteiraAlimentacao, @IdAlimento, '@DataInicio', '@DataTermino', @IdVeterinario, @FrequenciaDiaria, @Quantidade)"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraAlimentacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdAlimento", obj.IdAlimento);
                    cmd.Parameters.AddWithValue("@DataInicio", obj.DataInicio);
                    cmd.Parameters.AddWithValue("@DataTermino", obj.DataTermino);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@FrequenciaDiaria", obj.FrequenciaDiaria);
                    cmd.Parameters.AddWithValue("@Quantidade", obj.Quantidade);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(AlimentacaoModel obj)
        {
            return false;
        }
    }
}
