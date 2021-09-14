using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Item
{
    public class AlimentoDAL : BaseDAL<AlimentoModel>
    {
        private ConexaoDAO conexao;

        public AlimentoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Alimento WHERE IdAlimento = @id");

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

        internal override List<AlimentoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdAlimento, Tipo, Nome, Fabricante, Composicao FROM Alimento");

                List<AlimentoModel> retorno = new List<AlimentoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        AlimentoModel alimento = new AlimentoModel
                        {
                            IdAlimento = Convert.ToInt32(dataReader["IdAlimento"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        retorno.Add(alimento);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<AlimentoModel> GetByExample(AlimentoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdAlimento, Tipo, Nome, Fabricante, Composicao FROM Alimento WHERE 1 = 1");

                if (string.IsNullOrEmpty(obj.Tipo))
                {
                    query.AppendLine("AND Tipo = '@Tipo'");
                }

                if (string.IsNullOrEmpty(obj.Nome))
                {
                    query.AppendLine("AND Nome LIKE '%@Nome%'");
                }

                if (string.IsNullOrEmpty(obj.Fabricante))
                {
                    query.AppendLine("AND Fabricante = '@Fabricante'");
                }

                if (string.IsNullOrEmpty(obj.Composicao))
                {
                    query.AppendLine("AND Composicao = '%@Composicao%'");
                }

                List<AlimentoModel> retorno = new List<AlimentoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Fabricante", obj.Fabricante);
                    cmd.Parameters.AddWithValue("@Composicao", obj.Composicao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        AlimentoModel alimento = new AlimentoModel
                        {
                            IdAlimento = Convert.ToInt32(dataReader["IdAlimento"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        retorno.Add(alimento);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override AlimentoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdAlimento, Tipo, Nome, Fabricante, Composicao FROM Alimento WHERE IdAlimento = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdAlimento", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        AlimentoModel alimento = new AlimentoModel
                        {
                            IdAlimento = Convert.ToInt32(dataReader["IdAlimento"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        return alimento;
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

        internal override bool Insert(AlimentoModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Alimento (Tipo, Nome, Fabricante, Composicao) VALUES('@Tipo', '@Nome', '@Fabricante', '@Composicao')");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Fabricante", obj.Fabricante);
                    cmd.Parameters.AddWithValue("@Composicao", obj.Composicao);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(AlimentoModel obj)
        {
            try
            {
                string query = string.Format(@"UPDATE Alimento SET Tipo = '@Tipo', Nome = '@Nome', Fabricante = '@Fabricante', Composicao = '@Composicao' WHERE IdAlimento = @IdAlimento");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdAlimento", obj.IdAlimento);
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Fabricante", obj.Fabricante);
                    cmd.Parameters.AddWithValue("@Composicao", obj.Composicao);

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
