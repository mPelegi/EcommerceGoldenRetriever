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
    public class MedicacaoDAL : BaseDAL<MedicacaoModel>
    {
        private ConexaoDAO conexao;

        public MedicacaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Medicacao WHERE IdMedicacao = @id");

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

        internal override List<MedicacaoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdMedicacao, IdCarteiraMedicacao, IdMedicamento, DataInicio, DataTermino, IdVeterinario, Posologia, Justificativa FROM Medicacao");
                List<MedicacaoModel> retorno = new List<MedicacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        MedicacaoModel medicacao = new MedicacaoModel
                        {
                            IdMedicacao = Convert.ToInt32(dataReader["IdMedicacao"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraMedicacao"]),
                            IdMedicamento = Convert.ToInt32(dataReader["IdMedicamento"]),
                            DataInicio = dataReader["DataInicio"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataInicio"]),
                            DataTermino = dataReader["DataTermino"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataTermino"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Posologia = Convert.ToDecimal(dataReader["Posologia"]),
                            Justificativa = Convert.ToString(dataReader["Justificativa"]),
                        };
                        medicacao.CarteiraMedicacao = new CarteiraMedicacaoBLL().ObterPeloId(medicacao.IdCarteira);
                        medicacao.Veterinario = new VeterinarioBLL().ObterPeloId(medicacao.IdVeterinario);

                        retorno.Add(medicacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<MedicacaoModel> GetByExample(MedicacaoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdMedicacao, IdCarteiraMedicacao, IdMedicamento, DataInicio, DataTermino, IdVeterinario, Posologia, Justificativa FROM Medicacao WHERE 1 = 1");

                if (obj.IdCarteira > 0)
                {
                    query.AppendLine("AND IdCarteiraMedicacao = @IdCarteira");
                }

                if (obj.IdMedicamento > 0)
                {
                    query.AppendLine("AND IdMedicamento = @IdMedicamento");
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

                if (obj.Posologia > 0)
                {
                    query.AppendLine("AND Posologia = @Posologia");
                }

                if (!string.IsNullOrEmpty(obj.Justificativa))
                {
                    query.AppendLine("AND Justificativa LIKE '%@Justificativa%'");
                }

                List<MedicacaoModel> retorno = new List<MedicacaoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraMedicacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdMedicamento", obj.IdMedicamento);
                    cmd.Parameters.AddWithValue("@DataInicio", obj.DataInicio);
                    cmd.Parameters.AddWithValue("@DataTermino", obj.DataTermino);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@Posologia", obj.Posologia);
                    cmd.Parameters.AddWithValue("@Justificativa", obj.Justificativa);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        MedicacaoModel medicacao = new MedicacaoModel
                        {
                            IdMedicacao = Convert.ToInt32(dataReader["IdMedicacao"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraMedicacao"]),
                            IdMedicamento = Convert.ToInt32(dataReader["IdMedicamento"]),
                            DataInicio = dataReader["DataInicio"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataInicio"]),
                            DataTermino = dataReader["DataTermino"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataTermino"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Posologia = Convert.ToDecimal(dataReader["Posologia"]),
                            Justificativa = Convert.ToString(dataReader["Justificativa"]),
                        };
                        medicacao.CarteiraMedicacao = new CarteiraMedicacaoBLL().ObterPeloId(medicacao.IdCarteira);
                        medicacao.Veterinario = new VeterinarioBLL().ObterPeloId(medicacao.IdVeterinario);

                        retorno.Add(medicacao);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override MedicacaoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdMedicacao, IdCarteiraMedicacao, IdMedicamento, DataAplicacao, IdVeterinario, Posologia, Justificativa
                    FROM Medicacao
                    WHERE IdMedicacao = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCarteiraMedicacao", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        MedicacaoModel medicacao = new MedicacaoModel
                        {
                            IdMedicacao = Convert.ToInt32(dataReader["IdMedicacao"]),
                            IdCarteira = Convert.ToInt32(dataReader["IdCarteiraMedicacao"]),
                            IdMedicamento = Convert.ToInt32(dataReader["IdMedicamento"]),
                            DataInicio = dataReader["DataInicio"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataInicio"]),
                            DataTermino = dataReader["DataTermino"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataTermino"]),
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            Posologia = Convert.ToDecimal(dataReader["Posologia"]),
                            Justificativa = Convert.ToString(dataReader["Justificativa"]),
                        };
                        medicacao.CarteiraMedicacao = new CarteiraMedicacaoBLL().ObterPeloId(medicacao.IdCarteira);
                        medicacao.Veterinario = new VeterinarioBLL().ObterPeloId(medicacao.IdVeterinario);

                        return medicacao;
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

        internal override bool Insert(MedicacaoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO Medicacao (IdCarteiraMedicacao, IdMedicamento, DataAplicacao, IdVeterinario, Posologia, Justificativa) 
                    VALUES(@IdCarteiraMedicacao, @IdMedicamento, '@DataAplicacao', @IdVeterinario, @Posologia, '@Justificativa')"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdMedicacao", obj.IdMedicacao);
                    cmd.Parameters.AddWithValue("@IdCarteiraMedicacao", obj.IdCarteira);
                    cmd.Parameters.AddWithValue("@IdMedicamento", obj.IdMedicamento);
                    cmd.Parameters.AddWithValue("@DataInicio", obj.DataInicio);
                    cmd.Parameters.AddWithValue("@DataTermino", obj.DataTermino);
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@Posologia", obj.Posologia);
                    cmd.Parameters.AddWithValue("@Justificativa", obj.Justificativa);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(MedicacaoModel obj)
        {
            return false;
        }
    }
}
