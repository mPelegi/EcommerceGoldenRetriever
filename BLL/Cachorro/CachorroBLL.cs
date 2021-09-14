using EcommerceGoldenRetriever.MVC.DAL.Cachorro;
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

                return Dal.Delete(id);
            }
            catch (Exception e)
            {
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

                return Dal.GetAll();
            }
            catch (Exception e)
            {
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

                return Dal.GetByExample(exemplo);
            }
            catch (Exception e)
            {
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

                return Dal.GetById(id);
            }
            catch (Exception e)
            {
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

                return Dal.Insert(cachorro);
            }
            catch (Exception e)
            {
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

                return Dal.Update(cachorro);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

    }
}
