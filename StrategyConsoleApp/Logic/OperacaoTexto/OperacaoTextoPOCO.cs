using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.OperacaoTexto
{
    public class OperacaoTextoPOCO : AbstractPOCOViewModel
    {
        public string Operacao { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
