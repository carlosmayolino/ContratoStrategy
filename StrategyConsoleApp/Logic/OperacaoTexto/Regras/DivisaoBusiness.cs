using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.OperacaoTexto.Regras
{
    /// <summary>
    /// Divide o N1 pelo N2
    /// </summary>
    public class DivisaoBusiness : AbstractRegra<OperacaoTextoPOCO, string>
    {
        public DivisaoBusiness(OperacaoTextoPOCO instancia) : base(instancia)
        {

        }

        public override void Consistir()
        {
            Result = (Instancia.Num1 / Instancia.Num2).ToString();
        }
    }
}
