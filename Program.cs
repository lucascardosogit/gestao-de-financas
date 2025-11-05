using gestao_de_financas.Assuntos;
using gestao_de_financas.Observadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_de_financas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 


        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Assunto valorFinanca1 = new Assunto(1, "Creche", 19.00, DateTime.Now);
            Console.WriteLine($"Saldo atual: R$ ${valorFinanca1.getValor()}");

            Observador saldoDeEntradas = new Observador("saldoDeEntradas", valorFinanca1);
            Observador saldoDeSaidas = new Observador("saldoDeSaidas", valorFinanca1);

            
        }
    }
}
