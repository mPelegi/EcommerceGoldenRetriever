using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceGoldenRetriever.MVC.Helpers
{
    public class LoggerHelper
    {
        private static LoggerHelper Instance = null;
        public StringBuilder Logs { get; private set; }

        private LoggerHelper()
        {
            Logs = new StringBuilder();
        }

        public static LoggerHelper GetInstance()
        {
            if (Instance == null)
            {
                Instance = new LoggerHelper();
            }

            return Instance;
        }

        public void NewLog(string tipo, string acao, string tabela)
        {
            string log = new string($"{DateTime.Now}: {tipo.ToUpper()} - {acao.ToUpper()} - TABELA({tabela})");
            Logs.AppendLine(log);
        }
    }
}
