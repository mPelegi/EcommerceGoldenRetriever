using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.DAL.Venda;
using EcommerceGoldenRetriever.MVC.Helpers;
using EcommerceGoldenRetriever.MVC.Models.DAO;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.BLL.Venda
{
    public class VendaBLL
    {
        private VendaDAL Dal;
        private ConexaoDAO Conexao;
        private LoggerHelper Log = LoggerHelper.GetInstance();

        public VendaBLL()
        {
            try
            {
                Conexao = new ConexaoDAO();
                Dal = new VendaDAL(Conexao);
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
                Log.NewLog("Command", "DELETE", "Venda");

                return Dal.Delete(id);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "DELETE", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public List<VendaModel> ObterTodos()
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "SELECT ALL", "Venda");

                return Dal.GetAll();
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "SELECT ALL", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public List<VendaModel> ObterPeloExemplo(VendaModel exemplo)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "SELECT BY EXAMPLE", "Venda");

                return Dal.GetByExample(exemplo);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "SELECT BY EXAMPLE", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public VendaModel ObterPeloId(int id)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "SELECT BY ID", "Venda");

                return Dal.GetById(id);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "SELECT BY ID", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public bool Inserir(VendaModel venda)
        {
            try
            {
                Conexao.Abrir();

                venda.Cachorro.Reservado = true;
                venda.Cachorro.IdComprador = venda.IdComprador;

                new CachorroBLL().Atualizar(venda.Cachorro);

                Log.NewLog("Command", "INSERT", "Venda");

                return Dal.Insert(venda);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "INSERT", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public bool Atualizar(VendaModel venda)
        {
            try
            {
                Conexao.Abrir();
                Log.NewLog("Command", "UPDATE", "Venda");

                return Dal.Update(venda);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "UPDATE", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        public bool Cancelar(VendaModel venda)
        {
            try
            {
                Conexao.Abrir();

                venda.Cachorro.Reservado = false;
                venda.Status = "Cancelado";

                new CachorroBLL().Atualizar(venda.Cachorro);

                Log.NewLog("Command", "UPDATE (Cancelar)", "Venda");

                return Dal.Update(venda);
            }
            catch (Exception e)
            {
                Log.NewLog("Error", "UPDATE (Cancelar)", "Venda");
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }
    }
}
