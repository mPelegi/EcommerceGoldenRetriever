using EcommerceGoldenRetriever.MVC.DAL.Cachorro;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Cachorro
{
    public class CarteiraAlimentacaoBLL
    {
        private CarteiraAlimentacaoDAL Dal;
        private ConexaoDAO Conexao;

        public CarteiraAlimentacaoBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new CarteiraAlimentacaoDAL(Conexao);
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

        public List<CarteiraAlimentacaoModel> ObterTodos()
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

        public List<CarteiraAlimentacaoModel> ObterPeloExemplo(CarteiraAlimentacaoModel exemplo)
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

        public CarteiraAlimentacaoModel ObterPeloId(int id)
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

        public bool Inserir(CarteiraAlimentacaoModel carteiraAlimentacao)
        {
            try
            {
                Conexao.Abrir();

                return Dal.Insert(carteiraAlimentacao);
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
