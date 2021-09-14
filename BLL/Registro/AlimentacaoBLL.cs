using EcommerceGoldenRetriever.MVC.DAL.Registro;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Registro
{
    public class AlimentacaoBLL
    {
        private AlimentacaoDAL Dal;
        private ConexaoDAO Conexao;

        public AlimentacaoBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new AlimentacaoDAL(Conexao);
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

        public List<AlimentacaoModel> ObterTodos()
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

        public List<AlimentacaoModel> ObterPeloExemplo(AlimentacaoModel exemplo)
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

        public AlimentacaoModel ObterPeloId(int id)
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

        public bool Inserir(AlimentacaoModel alimentacao)
        {
            try
            {
                Conexao.Abrir();

                return Dal.Insert(alimentacao);
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
