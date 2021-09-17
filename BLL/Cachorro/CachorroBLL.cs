using EcommerceGoldenRetriever.MVC.DAL.Cachorro;
using EcommerceGoldenRetriever.MVC.Helpers;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Cachorro
{
    public class CachorroBLL
    {
        private CachorroDAL Dal;
        private ConexaoDAO Conexao;
        private LoggerHelper Log = LoggerHelper.GetInstance();


        public CachorroBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new CachorroDAL(Conexao);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool Deletar(int id)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "DELETE", "Cachorro");

                return Dal.Delete(id);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "DELETE", "Cachorro");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public List<CachorroModel> ObterTodos()
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "SELECT ALL", "Cachorro");

                return Dal.GetAll();
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "SELECT ALL", "Cachorro");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public List<CachorroModel> ObterPeloExemplo(CachorroModel exemplo)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "SELECT BY EXAMPLE", "Cachorro");

                return Dal.GetByExample(exemplo);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "SELECT BY EXAMPLE", "Cachorro");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public CachorroModel ObterPeloId(int id)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "SELECT BY ID", "Cachorro");

                return Dal.GetById(id);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "SELECT BY ID", "Cachorro");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public bool Inserir(CachorroModel cachorro)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "INSERT", "Cachorro");

                return Dal.Insert(cachorro);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "INSERT", "Cachorro");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public bool Atualizar(CachorroModel cachorro)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "UPDATE", "Cachorro");

                return Dal.Update(cachorro);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "UPDATE", "Cachorro");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

    }
}
