using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Pessoa
{
    public class CriadorDAL : BaseDAL<CriadorModel>
    {
        private ConexaoDAO conexao;

        public CriadorDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }
        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Criador WHERE IdCriador = @id");

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

        internal override List<CriadorModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdCriador, Nome, Documento, Telefone, DataNascimento, Endereco FROM Criador");

                List<CriadorModel> retorno = new List<CriadorModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CriadorModel criador = new CriadorModel
                        {
                            IdCriador = Convert.ToInt32(dataReader["IdCriador"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Documento = Convert.ToString(dataReader["Documento"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        retorno.Add(criador);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CriadorModel> GetByExample(CriadorModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdCriador, Nome, Documento, Telefone, DataNascimento, Endereco FROM Criador WHERE 1 = 1");

                if (string.IsNullOrEmpty(obj.Nome))
                {
                    query.AppendLine("AND Nome LIKE '%@Nome%'");
                }

                if (string.IsNullOrEmpty(obj.Documento))
                {
                    query.AppendLine("AND Documento LIKE '@Documento'");
                }

                if (string.IsNullOrEmpty(obj.Telefone))
                {
                    query.AppendLine("AND Telefone = '@Telefone'");
                }

                if (string.IsNullOrEmpty(obj.DataNascimento))
                {
                    query.AppendLine("AND DataNascimento = '@DataNascimento'");
                }

                if (string.IsNullOrEmpty(obj.Endereco))
                {
                    query.AppendLine("AND Endereco LIKE '%@Endereco%'");
                }

                List<CriadorModel> retorno = new List<CriadorModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CriadorModel criador = new CriadorModel
                        {
                            IdCriador = Convert.ToInt32(dataReader["IdCriador"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Documento = Convert.ToString(dataReader["Documento"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        retorno.Add(criador);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CriadorModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdCriador, Nome, Documento, Telefone, DataNascimento, Endereco FROM Criador WHERE IdCriador = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CriadorModel criador = new CriadorModel
                        {
                            IdCriador = Convert.ToInt32(dataReader["IdCriador"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Documento = Convert.ToString(dataReader["Documento"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        return criador;
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

        internal override bool Insert(CriadorModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Criador (Nome, Documento, Telefone, DataNascimento, Endereco) VALUES('@Nome', '@Documento', '@Telefone', '@DataNascimento', '@Endereco')");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(CriadorModel obj)
        {
            try
            {
                string query = string.Format(@"
                    UPDATE Criador SET Nome = '@Nome', Documento = '@Documento', Telefone = '@Telefone', DataNascimento = '@DataNascimento', Endereco = '@Endereco' 
                    WHERE IdCriador = @IdCriador");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCriador", obj.IdCriador);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
