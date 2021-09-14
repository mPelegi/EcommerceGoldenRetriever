using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Item
{
    public class MedicamentoDAL : BaseDAL<MedicamentoModel>
    {
        private ConexaoDAO conexao;

        public MedicamentoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Medicamento WHERE IdMedicamento = @id");

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

        internal override List<MedicamentoModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdMedicamento, Tipo, Nome, Fabricante, Composicao FROM Medicamento");

                List<MedicamentoModel> retorno = new List<MedicamentoModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        MedicamentoModel medicamento = new MedicamentoModel
                        {
                            IdMedicamento = Convert.ToInt32(dataReader["IdMedicamento"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        retorno.Add(medicamento);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<MedicamentoModel> GetByExample(MedicamentoModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdMedicamento, Tipo, Nome, Fabricante, Composicao FROM Medicamento WHERE 1 = 1");

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

                List<MedicamentoModel> retorno = new List<MedicamentoModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Fabricante", obj.Fabricante);
                    cmd.Parameters.AddWithValue("@Composicao", obj.Composicao);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        MedicamentoModel medicamento = new MedicamentoModel
                        {
                            IdMedicamento = Convert.ToInt32(dataReader["IdMedicamento"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        retorno.Add(medicamento);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override MedicamentoModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"SELECT IdMedicamento, Tipo, Nome, Fabricante, Composicao FROM Medicamento WHERE IdMedicamento = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdMedicamento", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        MedicamentoModel medicamento = new MedicamentoModel
                        {
                            IdMedicamento = Convert.ToInt32(dataReader["IdMedicamento"]),
                            Tipo = Convert.ToString(dataReader["Tipo"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Composicao = Convert.ToString(dataReader["Composicao"])
                        };

                        return medicamento;
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

        internal override bool Insert(MedicamentoModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Medicamento (Tipo, Nome, Fabricante, Composicao) VALUES('@Tipo', '@Nome', '@Fabricante', '@Composicao')");

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

        internal override bool Update(MedicamentoModel obj)
        {
            try
            {
                string query = string.Format(@"UPDATE Medicamento SET Tipo = '@Tipo', Nome = '@Nome', Fabricante = '@Fabricante', Composicao = '@Composicao' WHERE IdMedicamento = @IdMedicamento");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdMedicamento", obj.IdMedicamento);
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
