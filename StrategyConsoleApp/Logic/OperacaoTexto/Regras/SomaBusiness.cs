using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.OperacaoTexto.Regras
{
    public class SomaBusiness : AbstractRegra<OperacaoTextoPOCO, string>
    {
        public SomaBusiness(OperacaoTextoPOCO instancia) : base(instancia)
        {

        }
        public override void Consistir()
        {
            Result = (Instancia.Num1 + Instancia.Num2).ToString();
        }
    }
}
