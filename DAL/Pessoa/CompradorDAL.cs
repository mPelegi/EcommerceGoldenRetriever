using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Pessoa
{
    public class CompradorDAL : BaseDAL<CompradorModel>
    {
        private ConexaoDAO conexao;

        public CompradorDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Comprador WHERE IdComprador = @id");

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

        internal override List<CompradorModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdComprador, Nome, Telefone, DataNascimento, Endereco FROM Comprador");

                List<CompradorModel> retorno = new List<CompradorModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CompradorModel comprador = new CompradorModel
                        {
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        retorno.Add(comprador);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CompradorModel> GetByExample(CompradorModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdComprador, Nome, Telefone, DataNascimento, Endereco FROM Comprador WHERE 1 = 1");

                if (string.IsNullOrEmpty(obj.Nome))
                {
                    query.AppendLine("AND Nome LIKE '%@Nome%'");
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

                List<CompradorModel> retorno = new List<CompradorModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CompradorModel comprador = new CompradorModel
                        {
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        retorno.Add(comprador);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CompradorModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdComprador, Nome, Telefone, DataNascimento, Endereco FROM Comprador WHERE IdComprador = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CompradorModel comprador = new CompradorModel
                        {
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        return comprador;
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

        internal override bool Insert(CompradorModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Comprador (Nome, Telefone, DataNascimento, Endereco) VALUES('Nome', 'Telefone', 'DataNascimento', 'Endereco')");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
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

        internal override bool Update(CompradorModel obj)
        {
            try
            {
                string query = string.Format(@"
                    UPDATE Comprador SET Nome = '@Nome', Telefone = '@Telefone', DataNascimento = '@DataNascimento', Endereco = '@Endereco' 
                    WHERE IdComprador = @IdComprador"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdComprador", obj.IdComprador);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
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
