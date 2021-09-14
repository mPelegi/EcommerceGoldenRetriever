using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Pessoa
{
    public class DonoDAL : BaseDAL<DonoModel>
    {
        private ConexaoDAO conexao;

        public DonoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }
        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Dono WHERE IdDono = @id");

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

        internal override List<DonoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdDono, Nome, Telefone, DataNascimento, Endereco FROM Dono");

                List<DonoModel> retorno = new List<DonoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DonoModel dono = new DonoModel
                        {
                            IdDono = Convert.ToInt32(dataReader["IdDono"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        retorno.Add(dono);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<DonoModel> GetByExample(DonoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdDono, Nome, Telefone, DataNascimento, Endereco FROM Dono WHERE 1 = 1");

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

                List<DonoModel> retorno = new List<DonoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DonoModel dono = new DonoModel
                        {
                            IdDono = Convert.ToInt32(dataReader["IdDono"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        retorno.Add(dono);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override DonoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdDono, Nome, Telefone, DataNascimento, Endereco FROM Dono WHERE IdDono = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        DonoModel dono = new DonoModel
                        {
                            IdDono = Convert.ToInt32(dataReader["IdDono"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Telefone = Convert.ToString(dataReader["Telefone"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Endereco = Convert.ToString(dataReader["Endereco"])
                        };

                        return dono;
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

        internal override bool Insert(DonoModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Dono (Nome, Telefone, DataNascimento, Endereco) VALUES('Nome', 'Telefone', 'DataNascimento', 'Endereco')");

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

        internal override bool Update(DonoModel obj)
        {
            try
            {
                string query = string.Format(@"
                    UPDATE Dono SET Nome = '@Nome', Telefone = '@Telefone', DataNascimento = '@DataNascimento', Endereco = '@Endereco' 
                    WHERE IdDono = @IdDono");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdDono", obj.IdDono);
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
