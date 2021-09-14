using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Cachorro
{
    public class CachorroDAL : BaseDAL<CachorroModel>
    {
        private ConexaoDAO conexao;

        public CachorroDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Cachorro WHERE IdCachorro = @id");

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

        internal override List<CachorroModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdCachorro, Nome, Porte, DataNascimento, Raca, Sexo, Pedigree, IdMatriz, IdPadreador, Reservado, IdDono, IdComprador FROM Cachorro");
                List<CachorroModel> retorno = new List<CachorroModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while(dataReader.Read())
                    {
                        CachorroModel cachorro = new CachorroModel
                        {
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Porte = Convert.ToString(dataReader["Porte"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.Now.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Raca = Convert.ToString(dataReader["Raca"]),
                            Sexo = Convert.ToString(dataReader["Sexo"]),
                            Pedigree = Convert.ToInt32(dataReader["Pedigree"]),
                            IdMatriz = Convert.ToInt32(dataReader["IdMatriz"]),
                            IdPadreador = Convert.ToInt32(dataReader["IdPadreador"]),
                            Reservado = dataReader["Reservado"] != DBNull.Value && (bool)dataReader["Reservado"],
                            IdDono = Convert.ToInt32(dataReader["IdDono"]),
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"])
                        };

                        retorno.Add(cachorro);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<CachorroModel> GetByExample(CachorroModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT IdCachorro, Nome, Porte, DataNascimento, Raca, Sexo, Pedigree, IdMatriz, IdPadreador, Reservado, IdDono, IdComprador FROM Cachorro WHERE 1 = 1");

                if (obj.IdCachorro > 0)
                {
                    query.Append("AND IdCachorro = @IdCachorro");
                }

                if (string.IsNullOrEmpty(obj.Nome))
                {
                    query.Append("AND Nome = @Nome");
                }

                if (string.IsNullOrEmpty(obj.Porte))
                {
                    query.Append("AND Porte = @Porte");
                }

                if (string.IsNullOrEmpty(obj.DataNascimento))
                {
                    query.Append("AND DataNascimento = @DataNascimento");
                }

                if (string.IsNullOrEmpty(obj.Raca))
                {
                    query.Append("AND Raca = @Raca");
                }

                if (string.IsNullOrEmpty(obj.Sexo))
                {
                    query.Append("AND Sexo = @Sexo");
                }

                if (obj.Pedigree > 0)
                {
                    query.Append("AND Pedigree = @Pedigree");
                }

                if (obj.IdMatriz > 0)
                {
                    query.Append("AND IdMatriz = @IdMatriz");
                }

                if (obj.IdPadreador > 0)
                {
                    query.Append("AND IdPadreador = @IdPadreador");
                }

                if (obj.Reservado != null)
                {
                    query.Append("AND Reservado = @Reservado");
                }

                List<CachorroModel> retorno = new List<CachorroModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Porte", obj.Porte);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Raca", obj.Raca);
                    cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);
                    cmd.Parameters.AddWithValue("@Pedigree", obj.Pedigree);
                    cmd.Parameters.AddWithValue("@IdMatriz", obj.IdMatriz);
                    cmd.Parameters.AddWithValue("@IdPadreador", obj.IdPadreador);
                    cmd.Parameters.AddWithValue("@Reservado", (bool)obj.Reservado ? 1 : 0);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CachorroModel cachorro = new CachorroModel
                        {
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Porte = Convert.ToString(dataReader["Porte"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Raca = Convert.ToString(dataReader["Raca"]),
                            Sexo = Convert.ToString(dataReader["Sexo"]),
                            Pedigree = Convert.ToInt32(dataReader["Pedigree"]),
                            IdMatriz = Convert.ToInt32(dataReader["IdMatriz"]),
                            IdPadreador = Convert.ToInt32(dataReader["IdPadreador"]),
                            Reservado = dataReader["Reservado"] != DBNull.Value && (bool)dataReader["Reservado"],
                            IdDono = Convert.ToInt32(dataReader["IdDono"]),
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"])
                        };

                        retorno.Add(cachorro);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override CachorroModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdCachorro, Nome, Porte, DataNascimento, Raca, Sexo, Pedigree, IdMatriz, IdPadreador, Reservado, IdDono, IdComprador
                    FROM Cachorro 
                    WHERE IdCachorro = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        CachorroModel cachorro = new CachorroModel
                        {
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            Nome = Convert.ToString(dataReader["Nome"]),
                            Porte = Convert.ToString(dataReader["Porte"]),
                            DataNascimento = dataReader["DataNascimento"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataNascimento"]),
                            Raca = Convert.ToString(dataReader["Raca"]),
                            Sexo = Convert.ToString(dataReader["Sexo"]),
                            Pedigree = Convert.ToInt32(dataReader["Pedigree"]),
                            IdMatriz = Convert.ToInt32(dataReader["IdMatriz"]),
                            IdPadreador = Convert.ToInt32(dataReader["IdPadreador"]),
                            Reservado = dataReader["Reservado"] != DBNull.Value && (bool)dataReader["Reservado"],
                            IdDono = Convert.ToInt32(dataReader["IdDono"]),
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"])
                        };

                        return cachorro;
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

        internal override bool Insert(CachorroModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO Cachorro (Nome, Porte, DataNascimento, Raca, Sexo, Pedigree, IdMatriz, IdPadreador, Reservado, IdDono, IdComprador) 
                    VALUES(@Nome, @Porte, @DataNascimento, @Raca, @Sexo, @Pedigree, @IdMatriz, @IdPadreador, @Reservado, @IdDono, @IdComprador)"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Porte", obj.Porte);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Raca", obj.Raca);
                    cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);
                    cmd.Parameters.AddWithValue("@Pedigree", obj.Pedigree);
                    cmd.Parameters.AddWithValue("@IdMatriz", obj.IdMatriz);
                    cmd.Parameters.AddWithValue("@IdPadreador", obj.IdPadreador);
                    cmd.Parameters.AddWithValue("@Reservado", (bool)obj.Reservado ? 1 : 0);
                    cmd.Parameters.AddWithValue("@IdDono", obj.IdDono);
                    cmd.Parameters.AddWithValue("@IdComprador", obj.IdComprador);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
            
        }

        internal override bool Update(CachorroModel obj)
        {
            try
            {
                string query = string.Format(@"
                    UPDATE Cachorro SET Nome = @Nome, Porte = @Porte, DataNascimento = @DataNascimento, Raca = @Raca, Sexo = @Sexo, Pedigree = @Pedigree, IdMatriz = @IdMatriz, IdPadreador = @IdPadreador, Reservado = @Reservado
                    WHERE IdCachorro = @IdCachorro"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@Porte", obj.Porte);
                    cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                    cmd.Parameters.AddWithValue("@Raca", obj.Raca);
                    cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);
                    cmd.Parameters.AddWithValue("@Pedigree", obj.Pedigree);
                    cmd.Parameters.AddWithValue("@IdMatriz", obj.IdMatriz);
                    cmd.Parameters.AddWithValue("@IdPadreador", obj.IdPadreador);
                    cmd.Parameters.AddWithValue("@Reservado", (bool)obj.Reservado ? 1 : 0);

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
