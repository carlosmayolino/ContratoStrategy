using StrategyConsoleApp.Logic;
using StrategyConsoleApp.Logic.OperacaoTexto;
using StrategyConsoleApp.Logic.PesquisaEnum;
using System;

namespace StrategyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarPesquisaEnum();

            TestarOperacaoTexto();

            Console.ReadLine();




        }

        private static void TestarOperacaoTexto()
        {
            var op1 = new OperacaoTextoPOCO { Num1 = 10, Num2 = 20, Operacao = "Soma" };
            var op2 = new OperacaoTextoPOCO { Num1 = 10, Num2 = 20, Operacao = "soma" };

            var estrategy = new ContratoOperacaoTextoEstrategy(new ContratoOperacaoTexto(), op1);
            estrategy.Executar();

            Console.WriteLine($"{estrategy.Result}");


            estrategy = new ContratoOperacaoTextoEstrategy(new ContratoOperacaoTexto(), op2);
            estrategy.Executar();

            Console.WriteLine($"{estrategy.Result}");

        }
        private static void TestarPesquisaEnum()
        {
            var pesquisa1 = new PesquisaEnumPOCO { Escolha = PesquisaEnum.Tipo.Pesquisa01, Valor = "Pesquisa 1" };
            var pesquisa2 = new PesquisaEnumPOCO { Escolha = PesquisaEnum.Tipo.Pesquisa800, Valor = "Pesquisa 800" };


            //PESQUISA 1;
            var contratoEstrategy = new ContratoPesquisaEstrategy(new ContratoPesquisa(), pesquisa1);
            if (contratoEstrategy.Executar())
                Console.WriteLine($"SUCESSO: {contratoEstrategy.Result}");
            else
                Console.WriteLine($"ERRO: {contratoEstrategy.Result}");

            Console.WriteLine($"/////// FIM DA PESQUISA 01. ///////");



            //PESQUISA 2;
            contratoEstrategy = new ContratoPesquisaEstrategy(new ContratoPesquisa(), pesquisa2);
            if (contratoEstrategy.Executar())
                Console.WriteLine($"SUCESSO: {contratoEstrategy.Result}");
            else
                Console.WriteLine($"ERRO: {contratoEstrategy.Result}");

            Console.WriteLine($"/////// FIM DA PESQUISA 02. ///////");
        }
    }
}
