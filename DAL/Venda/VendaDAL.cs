using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.DAL.Venda
{
    public class VendaDAL : BaseDAL<VendaModel>
    {
        private ConexaoDAO conexao;

        public VendaDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        internal override bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Venda WHERE IdVenda = @id");

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

        internal override List<VendaModel> GetAll()
        {
            try
            {
                string query = string.Format("SELECT IdVenda, IdCachorro, IdComprador, DataCompra, DataReserva, Status, Valor, NotaFiscal FROM Venda");

                List<VendaModel> retorno = new List<VendaModel>();

                using (SqlCommand cmd = new SqlCommand(query, conexao.Get()))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VendaModel venda = new VendaModel
                        {
                            IdVenda = Convert.ToInt32(dataReader["IdVenda"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"]),
                            DataCompra = dataReader["DataCompra"] == DBNull.Value ? DateTime.Now.ToString() : Convert.ToString(dataReader["DataCompra"]),
                            DataReserva = dataReader["DataReserva"] == DBNull.Value ? DateTime.Now.ToString() : Convert.ToString(dataReader["DataReserva"]),
                            Status = Convert.ToString(dataReader["Status"]),
                            Valor = Convert.ToDecimal(dataReader["Valor"]),
                            NotaFiscal = Convert.ToString(dataReader["NotaFiscal"])
                        };
                        venda.Cachorro = new CachorroBLL().ObterPeloId(venda.IdCachorro);
                        venda.Comprador = new CompradorBLL().ObterPeloId(venda.IdComprador);

                        retorno.Add(venda);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override List<VendaModel> GetByExample(VendaModel obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT IdVenda, IdCachorro, IdComprador, DataCompra, DataReserva, Status, Valor, NotaFiscal FROM Venda WHERE 1 = 1");

                if (obj.IdCachorro > 0)
                {
                    query.AppendLine("AND IdCachorro = @IdCachorro");
                }

                if (obj.IdComprador > 0)
                {
                    query.AppendLine("AND IdComprador = @IdComprador");
                }

                if (string.IsNullOrEmpty(obj.DataCompra))
                {
                    query.AppendLine("AND DataCompra = '@DataCompra'");
                }

                if (string.IsNullOrEmpty(obj.DataReserva))
                {
                    query.AppendLine("AND DataReserva = '@DataReserva'");
                }

                if (string.IsNullOrEmpty(obj.Status))
                {
                    query.AppendLine("AND Status = '@Status'");
                }

                if (obj.Valor > 0)
                {
                    query.AppendLine("AND Valor >= @Valor");
                }

                if (string.IsNullOrEmpty(obj.NotaFiscal))
                {
                    query.AppendLine("AND NotaFiscal = '@NotaFiscal'");
                }

                List<VendaModel> retorno = new List<VendaModel>();

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@IdComprador", obj.IdComprador);
                    cmd.Parameters.AddWithValue("@DataCompra", obj.DataCompra);
                    cmd.Parameters.AddWithValue("@DataReserva", obj.DataReserva);
                    cmd.Parameters.AddWithValue("@Status", obj.Status);
                    cmd.Parameters.AddWithValue("@Valor", obj.Valor);
                    cmd.Parameters.AddWithValue("@NotaFiscal", obj.NotaFiscal);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VendaModel venda = new VendaModel
                        {
                            IdVenda = Convert.ToInt32(dataReader["IdVenda"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"]),
                            DataCompra = dataReader["DataCompra"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataCompra"]),
                            DataReserva = dataReader["DataReserva"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataReserva"]),
                            Status = Convert.ToString(dataReader["Status"]),
                            Valor = Convert.ToDecimal(dataReader["Valor"]),
                            NotaFiscal = Convert.ToString(dataReader["NotaFiscal"]),
                        };
                        venda.Cachorro = new CachorroBLL().ObterPeloId(venda.IdCachorro);
                        venda.Comprador = new CompradorBLL().ObterPeloId(venda.IdComprador);

                        retorno.Add(venda);
                    }

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override VendaModel GetById(int id)
        {
            try
            {
                string query = string.Format(@"
                    SELECT IdVenda, IdCachorro, IdComprador, DataCompra, DataReserva, Status, Valor, NotaFiscal 
                    FROM Venda 
                    WHERE IdVenda = @id"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdVeterinario", id);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        VendaModel venda = new VendaModel
                        {
                            IdVenda = Convert.ToInt32(dataReader["IdVenda"]),
                            IdCachorro = Convert.ToInt32(dataReader["IdCachorro"]),
                            IdComprador = Convert.ToInt32(dataReader["IdComprador"]),
                            DataCompra = dataReader["DataCompra"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataCompra"]),
                            DataReserva = dataReader["DataReserva"] == DBNull.Value ? DateTime.MinValue.ToString() : Convert.ToString(dataReader["DataReserva"]),
                            Status = Convert.ToString(dataReader["Status"]),
                            Valor = Convert.ToDecimal(dataReader["Valor"]),
                            NotaFiscal = Convert.ToString(dataReader["NotaFiscal"]),
                        };
                        venda.Cachorro = new CachorroBLL().ObterPeloId(venda.IdCachorro);
                        venda.Comprador = new CompradorBLL().ObterPeloId(venda.IdComprador);

                        return venda;
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

        internal override bool Insert(VendaModel obj)
        {
            try
            {
                string query = string.Format(@"
                    INSERT INTO Venda (IdCachorro, IdComprador, DataCompra, DataReserva, Status, Valor, NotaFiscal)
                    VALUES(@IdCachorro, @IdComprador, @DataCompra, @DataReserva, @Status, @Valor, @NotaFiscal)"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdCachorro", obj.IdCachorro);
                    cmd.Parameters.AddWithValue("@IdComprador", obj.IdComprador);
                    cmd.Parameters.AddWithValue("@DataCompra", obj.DataCompra);
                    cmd.Parameters.AddWithValue("@DataReserva", obj.DataReserva);
                    cmd.Parameters.AddWithValue("@Status", obj.Status);
                    cmd.Parameters.AddWithValue("@Valor", obj.Valor);
                    cmd.Parameters.AddWithValue("@NotaFiscal", obj.NotaFiscal);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        internal override bool Update(VendaModel obj)
        {
            try
            {
                string query = string.Format(@"
                    UPDATE Venda SET DataCompra = @DataCompra, DataReserva = @DataReserva, Status = @Status, Valor = @Valor, NotaFiscal = @NotaFiscal
                    WHERE IdVenda = @IdVenda"
                );

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdVenda", obj.IdVenda);
                    cmd.Parameters.AddWithValue("@DataCompra", obj.DataCompra);
                    cmd.Parameters.AddWithValue("@DataReserva", obj.DataReserva);
                    cmd.Parameters.AddWithValue("@Status", obj.Status);
                    cmd.Parameters.AddWithValue("@Valor", obj.Valor);
                    cmd.Parameters.AddWithValue("@NotaFiscal", obj.NotaFiscal);

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
