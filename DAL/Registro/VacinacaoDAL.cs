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
    public class VacinacaoDAL : BaseDAL<VacinacaoModel>
    {
        private ConexaoDAO conexao;

        public VacinacaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Vacinacao WHERE IdVacinacao = @id");

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

        internal override List<VacinacaoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdVacinacao, IdCarteiraVacinacao, IdVacina, DataAplicacao, IdVeterinario, Dose, Observacao FROM Vacinacao");
                List<VacinacaoModel> retorno = new List<VacinacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VacinacaoModel vacinacao = new VacinacaoModel
                        {
                            IdVacinacao = Convert.ToInt32(dataReader["IdVacinacao"]),
                            IdVacina = Convert.ToInt32(dataReader["IdVacina"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraVacinacao"]),
                            DataAplicacao = dataReader["DataAplicacao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataAplicacao"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Dose = Convert.ToDecimal(dataReader["Dose"]),
                            Observacao = Convert.ToString(dataReader["Observacao"]),
                        };
                        vacinacao.CarteiraVacinacao = new CarteiraVacinacaoBLL().ObterPeloId(vacinacao.IdCarteira);
                        vacinacao.Veterinario = new VeterinarioBLL().ObterPeloId(vacinacao.IdVeterinario);

                        retorno.Add(vacinacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<VacinacaoModel> GetByExample(VacinacaoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdVacinacao, IdCarteiraVacinacao, IdVacina, DataAplicacao, IdVeterinario, Dose, Observacao FROM Vacinacao WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.AppendLine("AND IdCarteiraVacinacao = @IdCarteira");
                }

                if (obj.IdVacina > 0)
                {
                    query.AppendLine("AND IdVacina = @IdVacina");
                }

                if (string.IsNullOrEmpty(obj.DataAplicacao))
                {
                    query.AppendLine("AND DataAplicacao = '@DataAplicacao'");
                }

                if (obj.IdVeterinario > 0)
                {
                    query.AppendLine("AND IdVeterinario = @IdVeterinario");
                }

                if (obj.Dose > 0)
                {
                    query.AppendLine("AND Dose = @Dose");
                }

                if (!string.IsNullOrEmpty(obj.Observacao))
                {
                    query.AppendLine("AND Observacao LIKE '%@Observacao%'");
                }

                List<VacinacaoModel> retorno = new List<VacinacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraVacinacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdVacina", obj.IdVacina);
                    cmd.Parameters.AddWithValue("@DataAplicacao", obj.DataAplicacao);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@Dose", obj.Dose);
                    cmd.Parameters.AddWithValue("@Observacao", obj.Observacao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VacinacaoModel vacinacao = new VacinacaoModel
                        {
                            IdVacinacao = Convert.ToInt32(dataReader["IdVacinacao"]),
                            IdVacina = Convert.ToInt32(dataReader["IdVacina"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraVacinacao"]),
                            DataAplicacao = dataReader["DataAplicacao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataAplicacao"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Dose = Convert.ToDecimal(dataReader["Dose"]),
                            Observacao = Convert.ToString(dataReader["Observacao"]),
                        };
                        vacinacao.CarteiraVacinacao = new CarteiraVacinacaoBLL().ObterPeloId(vacinacao.IdCarteira);
                        vacinacao.Veterinario = new VeterinarioBLL().ObterPeloId(vacinacao.IdVeterinario);

                        retorno.Add(vacinacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override VacinacaoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdVacinacao, IdCarteiraVacinacao, IdVacina, DataAplicacao, IdVeterinario, Dose, Observacao
                    FROM Vacinacao
                    WHERE IdVacinacao = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraVacinacao", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        VacinacaoModel vacinacao = new VacinacaoModel
                        {
                            IdVacinacao = Convert.ToInt32(dataReader["IdVacinacao"]),
                            IdVacina = Convert.ToInt32(dataReader["IdVacina"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraVacinacao"]),
                            DataAplicacao = dataReader["DataAplicacao"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataAplicacao"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Dose = Convert.ToDecimal(dataReader["Dose"]),
                            Observacao = Convert.ToString(dataReader["Observacao"]),
                        };
                        vacinacao.CarteiraVacinacao = new CarteiraVacinacaoBLL().ObterPeloId(vacinacao.IdCarteira);
                        vacinacao.Veterinario = new VeterinarioBLL().ObterPeloId(vacinacao.IdVeterinario);

                        return vacinacao;
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

        internal override bool Insert(VacinacaoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO Vacinacao (IdCarteiraVacinacao, IdVacina, DataAplicacao, IdVeterinario, Dose, Observacao) 
                    VALUES(@IdCarteiraVacinacao, @IdVacina, @DataAplicacao, @IdVeterinario, @Dose, '@Observacao')"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraVacinacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdVacina", obj.IdVacina);
                    cmd.Parameters.AddWithValue("@DataAplicacao", obj.DataAplicacao);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@Dose", obj.Dose);
                    cmd.Parameters.AddWithValue("@Observacao", obj.Observacao);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(VacinacaoModel obj)
        {
            return false;
        }
    }
}
