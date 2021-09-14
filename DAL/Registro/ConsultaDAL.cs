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
    public class ConsultaDAL : BaseDAL<ConsultaModel>
    {
        private ConexaoDAO conexao;

        public ConsultaDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Consulta WHERE IdConsulta = @id");

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

        internal override List<ConsultaModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdConsulta, IdCarteiraExame, IdExame, DataExame, IdVeterinario, Resultado, Observacao FROM Consulta");
                List<ConsultaModel> retorno = new List<ConsultaModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ConsultaModel consulta = new ConsultaModel
                        {
                            IdConsulta = Convert.ToInt32(dataReader["IdConsulta"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraExame"]),
                            IdExame = Convert.ToInt32(dataReader["IdExame"]),
                            DataExame = dataReader["DataExame"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataExame"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Resultado = Convert.ToString(dataReader["Resultado"]),
                            Observacao = Convert.ToString(dataReader["Observacao"]),
                        };
                        consulta.CarteiraExame = new CarteiraExameBLL().ObterPeloId(consulta.IdCarteira);
                        consulta.Veterinario = new VeterinarioBLL().ObterPeloId(consulta.IdVeterinario);

                        retorno.Add(consulta);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<ConsultaModel> GetByExample(ConsultaModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdConsulta, IdCarteiraExame, IdExame, DataExame, IdVeterinario, Resultado, Observacao FROM Consulta WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.AppendLine("AND IdCarteiraExame = @IdCarteira");
                }

                if (obj.IdExame > 0)
                {
                    query.AppendLine("AND IdExame = @IdExame");
                }

                if (string.IsNullOrEmpty(obj.DataExame))
                {
                    query.AppendLine("AND DataExame = '@DataExame'");
                }

                if (obj.IdVeterinario > 0)
                {
                    query.AppendLine("AND IdVeterinario = @IdVeterinario");
                }

                if (string.IsNullOrEmpty(obj.Resultado))
                {
                    query.AppendLine("AND Resultado = '@Resultado'");
                }

                if (string.IsNullOrEmpty(obj.Observacao))
                {
                    query.AppendLine("AND Observacao = '@Observacao'");
                }

                List<ConsultaModel> retorno = new List<ConsultaModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraExame", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdExame", obj.IdExame);
                    cmd.Parameters.AddWithValue("@DataExame", obj.DataExame);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@Resultado", obj.Resultado);
                    cmd.Parameters.AddWithValue("@Observacao", obj.Observacao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ConsultaModel consulta = new ConsultaModel
                        {
                            IdConsulta = Convert.ToInt32(dataReader["IdConsulta"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraExame"]),
                            IdExame = Convert.ToInt32(dataReader["IdExame"]),
                            DataExame = dataReader["DataExame"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataExame"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Resultado = Convert.ToString(dataReader["Resultado"]),
                            Observacao = Convert.ToString(dataReader["Observacao"]),
                        };
                        consulta.CarteiraExame = new CarteiraExameBLL().ObterPeloId(consulta.IdCarteira);
                        consulta.Veterinario = new VeterinarioBLL().ObterPeloId(consulta.IdVeterinario);

                        retorno.Add(consulta);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override ConsultaModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdConsulta, IdCarteiraExame, IdExame, DataExame, IdVeterinario, Resultado, Observacao
                    FROM Consulta
                    WHERE IdConsulta = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraExame", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        ConsultaModel consulta = new ConsultaModel
                        {
                            IdConsulta = Convert.ToInt32(dataReader["IdConsulta"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraExame"]),
                            IdExame = Convert.ToInt32(dataReader["IdExame"]),
                            DataExame = dataReader["DataExame"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataExame"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Resultado = Convert.ToString(dataReader["Resultado"]),
                            Observacao = Convert.ToString(dataReader["Observacao"]),
                        };
                        consulta.CarteiraExame = new CarteiraExameBLL().ObterPeloId(consulta.IdCarteira);
                        consulta.Veterinario = new VeterinarioBLL().ObterPeloId(consulta.IdVeterinario);

                        return consulta;
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

        internal override bool Insert(ConsultaModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO Consulta (IdCarteiraExame, IdExame, DataExame, IdVeterinario, Resultado, Observacao) 
                    VALUES(@IdCarteiraExame, @IdExame, @DataExame, @IdVeterinario, @Resultado, @Observacao)"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraExame", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdExame", obj.IdExame);
                    cmd.Parameters.AddWithValue("@DataExame", obj.DataExame);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@Resultado", obj.Resultado);
                    cmd.Parameters.AddWithValue("@Observacao", obj.Observacao);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(ConsultaModel obj)
        {
            return false;
        }
    }
}
