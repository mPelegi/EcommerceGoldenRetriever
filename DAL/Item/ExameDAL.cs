using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Item
{
    public class ExameDAL : BaseDAL<ExameModel>
    {
        private ConexaoDAO conexao;

        public ExameDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Exame WHERE IdExame = @id");

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

        internal override List<ExameModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdExame, Tipo, Nome FROM Exame");

                List<ExameModel> retorno = new List<ExameModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ExameModel exame = new ExameModel
                        {
                            IdExame = Convert.ToInt32(dataReader["IdExame"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"])
                        };

                        retorno.Add(exame);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<ExameModel> GetByExample(ExameModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdExame, Tipo, Nome FROM Exame WHERE 1 = 1");

                if (string.IsNullOrEmpty(obj.Tipo))
                {
                    query.AppendLine("AND Tipo = '@Tipo'");
                }

                if (string.IsNullOrEmpty(obj.Nome))
                {
                    query.AppendLine("AND Nome LIKE '%@Nome%'");
                }

                List<ExameModel> retorno = new List<ExameModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ExameModel exame = new ExameModel
                        {
                            IdExame = Convert.ToInt32(dataReader["IdExame"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"])
                        };

                        retorno.Add(exame);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override ExameModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdExame, Tipo, Nome FROM Exame WHERE IdExame = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdExame", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        ExameModel exame = new ExameModel
                        {
                            IdExame = Convert.ToInt32(dataReader["IdExame"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"])
                        };

                        return exame;
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

        internal override bool Insert(ExameModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Exame (Tipo, Nome) VALUES('@Tipo', '@Nome')");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(ExameModel obj)
        {
            try
            {
                string query = string.Format(@"UPDATE Exame SET Tipo = '@Tipo', Nome = '@Nome' WHERE IdExame = @IdExame");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdExame", obj.IdExame);
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);

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
