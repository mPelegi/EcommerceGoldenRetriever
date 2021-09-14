using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Item
{
    public class VacinaDAL : BaseDAL<VacinaModel>
    {
        private ConexaoDAO conexao;

        public VacinaDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Vacina WHERE IdVacina = @id");

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

        internal override List<VacinaModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdVacina, Tipo, Nome, Fabricante, Composicao FROM Vacina");

                List<VacinaModel> retorno = new List<VacinaModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VacinaModel vacina = new VacinaModel
                        {
                            IdVacina = Convert.ToInt32(dataReader["IdVacina"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        retorno.Add(vacina);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<VacinaModel> GetByExample(VacinaModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdVacina, Tipo, Nome, Fabricante, Composicao FROM Vacina WHERE 1 = 1");

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

                List<VacinaModel> retorno = new List<VacinaModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Fabricante", obj.Fabricante);
                    cmd.Parameters.AddWithValue("@Composicao", obj.Composicao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VacinaModel vacina = new VacinaModel
                        {
                            IdVacina = Convert.ToInt32(dataReader["IdVacina"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        retorno.Add(vacina);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override VacinaModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdVacina, Tipo, Nome, Fabricante, Composicao FROM Vacina WHERE IdVacina = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdVacina", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        VacinaModel vacina = new VacinaModel
                        {
                            IdVacina = Convert.ToInt32(dataReader["IdVacina"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        return vacina;
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

        internal override bool Insert(VacinaModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Vacina (Tipo, Nome, Fabricante, Composicao) VALUES('@Tipo', '@Nome', '@Fabricante', '@Composicao')");

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

        internal override bool Update(VacinaModel obj)
        {
            try
            {
                string query = string.Format(@"UPDATE Vacina SET Tipo = '@Tipo', Nome = '@Nome', Fabricante = '@Fabricante', Composicao = '@Composicao' WHERE IdVacina = @IdVacina");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdVacina", obj.IdVacina);
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
