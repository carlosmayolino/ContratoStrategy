using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.OperacaoTexto.Regras
{
    public class SubtracaoBusiness : AbstractRegra<OperacaoTextoPOCO, string>
    {
        public SubtracaoBusiness(OperacaoTextoPOCO instancia) : base(instancia)
        {

        }
        public override void Consistir()
        {
            Result = (Instancia.Num1 - Instancia.Num2).ToString();
        }
    }
}
