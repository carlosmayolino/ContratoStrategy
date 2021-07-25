using StrategyConsoleApp.Logic.Abstract;
using System;

namespace StrategyConsoleApp.Logic.PesquisaEnum
{
    class Regra01 : AbstractRegra<PesquisaEnumPOCO, string>
    {
        public Regra01(PesquisaEnumPOCO instancia):base(instancia)
        {

        }
        public override void Consistir()
        {
            Result = $"{Instancia.Valor} - Executou a regra 01 - Mensagem";

            Console.WriteLine($"{Instancia.Valor} - Executou a regra 01");
        }
    }
}
