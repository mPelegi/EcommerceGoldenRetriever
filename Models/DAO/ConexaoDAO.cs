using EcommerceGoldenRetriever.MVC.DAL.Base;
using EcommerceGoldenRetriever.MVC.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceGoldenRetriever.MVC.Models.DAO
{
    public class ConexaoDAO
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        private static readonly string constring = @"Server=DESKTOP-GR81RMB\SQLEXPRESS;Database=EcommerceGolden;Trusted_Connection=True";
        private bool isOpen = false;
        private ConexaoDAL dal;

        public ConexaoDAO()
        {
            try
            {
                connection = new SqlConnection(constring);        
                dal = new ConexaoDAL(connection);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Abrir()
        {
            if (!isOpen)
            {
                connection.Open();

                isOpen = true;
            }

        }

        public void Fechar()
        {
            if (isOpen)
            {
                connection.Close();

                isOpen = false;
            }

        }

        public void AbrirTransacao()
        {
            try
            {
                transaction = connection.BeginTransaction();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlConnection Get()
        {

            try
            {
                return connection;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void CommitTransacao()
        {
            try
            {
                if (transaction == null)
                {
                    throw new Exception("Não existe uma Transaction aberta para commitar");
                }

                transaction.Commit();
                transaction = null;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void RollBackTransacao()
        {
            try
            {
                if (transaction == null)
                {
                    throw new Exception("Não existe uma Transaction aberta para rollback");
                }

                transaction.Rollback();
                transaction = null;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool ExisteTransacao()
        {
            try
            {
                if (transaction == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool IsOpen()
        {
            return isOpen;
        }
    }
}
