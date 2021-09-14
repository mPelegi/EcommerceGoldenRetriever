using EcommerceGoldenRetriever.MVC.DAL.Registro;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Registro
{
    public class ConsultaBLL
    {
        private ConsultaDAL Dal;
        private ConexaoDAO Conexao;

        public ConsultaBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new ConsultaDAL(Conexao);
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

        public List<ConsultaModel> ObterTodos()
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

        public List<ConsultaModel> ObterPeloExemplo(ConsultaModel exemplo)
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

        public ConsultaModel ObterPeloId(int id)
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

        public bool Inserir(ConsultaModel consulta)
        {
            try
            {
                Conexao.Abrir();

                return Dal.Insert(consulta);
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
