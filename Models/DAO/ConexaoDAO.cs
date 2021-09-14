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
        //private readonly string chaveLogin = "E9384ufdbuqndxLfoioKKjhKpotrity983ldg66";
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

        //private User VerficarToken(string chave)
        //{
        //    try
        //    {
        //        Abrir();

        //        if (string.IsNullOrEmpty(chave) || string.IsNullOrWhiteSpace(chave))
        //        {
        //            throw new ConexaoException("Chave Inválida");
        //        }

        //        User retorno = dal.VerificarToken(chave);


        //        if (retorno != null && VerificarUltimoAcesso(retorno.UltimoAcesso))
        //        {
        //            if (!dal.AtualizarUltimoAcesso(chave, retorno.Usuario))
        //            {
        //                throw new ConexaoException("Falha ao atualizar token de acesso, favor entrar em contato com o suporte");
        //            };

        //            return retorno;
        //        }
        //        else
        //        {
        //            return null;
        //        }


        //    }
        //    catch (Exception e)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        Fechar();
        //    }
        //}

        internal bool VerificarUltimoAcesso(string ultimoAcesso)
        {
            if (string.IsNullOrEmpty(ultimoAcesso))
            {
                return false;
            }

            DateTime dateInicial = DateTime.Parse(ultimoAcesso);

            TimeSpan timeSpan = DateTime.Now - dateInicial;


            if (timeSpan.TotalMinutes > 10)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void Abrir()
        {
            if (!this.isOpen)
            {
                this.connection.Open();

                this.isOpen = true;
            }

        }

        public void Fechar()
        {
            if (this.isOpen)
            {
                this.connection.Close();

                this.isOpen = false;
            }

        }

        public void AbrirTransacao()
        {
            try
            {
                this.transaction = this.connection.BeginTransaction();
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
                return this.connection;
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

                this.transaction.Commit();
                this.transaction = null;
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

                this.transaction.Rollback();
                this.transaction = null;
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
            return this.isOpen;
        }
    }
}
