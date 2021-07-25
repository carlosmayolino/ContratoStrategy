using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.PesquisaEnum
{
    public class PesquisaEnumPOCO : AbstractPOCOViewModel
    {
        public string Valor { get; set; }
        public PesquisaEnum.Tipo Escolha { get; set; }
    }
}
