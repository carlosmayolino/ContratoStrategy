using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.PesquisaEnum
{
    class Regra02 : AbstractRegra<PesquisaEnumPOCO, string>
    {
        public Regra02(PesquisaEnumPOCO instancia): base(instancia)
        {

        }
        public override void Consistir()
        {
            Result = $"{Instancia.Valor} - Executou a regra 02 - Mensagem";

            //Console.WriteLine($"{Instancia.Valor} - Executou a regra 02");
        }
    }
}
