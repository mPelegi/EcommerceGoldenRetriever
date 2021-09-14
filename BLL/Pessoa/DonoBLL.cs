using EcommerceGoldenRetriever.MVC.DAL.Pessoa;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Pessoa
{
    public class DonoBLL
    {
        private DonoDAL Dal;
        private ConexaoDAO Conexao;

        public DonoBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new DonoDAL(Conexao);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool Delete(int id)
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

        public List<DonoModel> ObterTodos()
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

        public List<DonoModel> ObterPeloExemplo(DonoModel exemplo)
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

        public DonoModel ObterPeloId(int id)
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

        public bool Inserir(DonoModel dono)
        {
            try
            {
                Conexao.Abrir();

                return Dal.Insert(dono);
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

        public bool Atualizar(DonoModel dono)
        {
            try
            {
                Conexao.Abrir();

                return Dal.Update(dono);
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
