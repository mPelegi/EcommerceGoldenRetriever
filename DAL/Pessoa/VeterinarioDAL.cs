using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Pessoa
{
    public class VeterinarioDAL : BaseDAL<VeterinarioModel>
    {
        private ConexaoDAO conexao;

        public VeterinarioDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Veterinario WHERE IdVeterinario = @id");

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

        internal override List<VeterinarioModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdVeterinario, CRMV, Nome, Especialidade FROM Veterinario");

                List<VeterinarioModel> retorno = new List<VeterinarioModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VeterinarioModel veterinario = new VeterinarioModel
                        {
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            CRMV = Convert.ToString(dataReader["CRMV"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Especialidade = Convert.ToString(dataReader["Especialidade"])
                        };

                        retorno.Add(veterinario);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<VeterinarioModel> GetByExample(VeterinarioModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdVeterinario, CRMV, Nome, Especialidade FROM Veterinario WHERE 1 = 1");

                if (string.IsNullOrEmpty(obj.CRMV))
                {
                    query.AppendLine("AND CRMV = '@CRMV'");
                }

                if (string.IsNullOrEmpty(obj.Nome))
                {
                    query.AppendLine("AND Nome LIKE '%@Nome%'");
                }

                if (string.IsNullOrEmpty(obj.Especialidade))
                {
                    query.AppendLine("AND Especialidade = '@Especialidade'");
                }

                List<VeterinarioModel> retorno = new List<VeterinarioModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@CRMV", obj.CRMV);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Especialidade", obj.Especialidade);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VeterinarioModel veterinario = new VeterinarioModel
                        {
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            CRMV = Convert.ToString(dataReader["CRMV"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Especialidade = Convert.ToString(dataReader["Especialidade"])
                        };

                        retorno.Add(veterinario);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override VeterinarioModel GetById(int id)
        {
            try 
            {
                string query = string.Format(@"SELECT IdVeterinario, CRMV, Nome, Especialidade FROM Veterinario WHERE IdVeterinario = @id");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        VeterinarioModel veterinario = new VeterinarioModel
                        {
                            IdVeterinario = Convert.ToInt32(dataReader["IdVeterinario"]),
                            CRMV = Convert.ToString(dataReader["CRMV"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Especialidade = Convert.ToString(dataReader["Especialidade"])
                        };

                        return veterinario;
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

        internal override bool Insert(VeterinarioModel obj)
        {
            try
            {
                string query = string.Format(@"INSERT INTO Veterinario (CRMV, Nome, Especialidade) VALUES('@CRMV', '@Nome', '@Especialidade')");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@CRMV", obj.CRMV);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Especialidade", obj.Especialidade);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(VeterinarioModel obj)
        {
            try
            {
                string query = string.Format(@"UPDATE Veterinario SET CRMV = '@CRMV', Nome = '@Nome', Especialidade = '@Especialidade' WHERE IdVeterinario = @IdVeterinario");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdVeterinario", obj.IdVeterinario);
                    cmd.Parameters.AddWithValue("@CRMV", obj.CRMV);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Especialidade", obj.Especialidade);

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
