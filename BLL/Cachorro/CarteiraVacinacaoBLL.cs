using EcommerceGoldenRetriever.MVC.DAL.Cachorro;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Cachorro
{
    public class CarteiraVacinacaoBLL
    {
        private CarteiraVacinacaoDAL Dal;
        private ConexaoDAO Conexao;

        public CarteiraVacinacaoBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new CarteiraVacinacaoDAL(Conexao);
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

        public List<CarteiraVacinacaoModel> ObterTodos()
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

        public List<CarteiraVacinacaoModel> ObterPeloExemplo(CarteiraVacinacaoModel exemplo)
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

        public CarteiraVacinacaoModel ObterPeloId(int id)
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

        public bool Inserir(CarteiraVacinacaoModel carteiraVacinacao)
        {
            try
            {
                Conexao.Abrir();

                return Dal.Insert(carteiraVacinacao);
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
