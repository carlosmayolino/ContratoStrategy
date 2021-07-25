using StrategyConsoleApp.Logic.Abstract;
using StrategyConsoleApp.Logic.OperacaoTexto.Regras;

namespace StrategyConsoleApp.Logic.OperacaoTexto
{
    public class ContratoOperacaoTexto : AbstractContrato<OperacaoTextoPOCO, string>
    {

        
        public override void IniciarContrato(OperacaoTextoPOCO instancia)
        {
            ListaRegras.Add("Soma", new SomaBusiness(instancia));
            ListaRegras.Add("Divisao", new DivisaoBusiness(instancia));
            ListaRegras.Add("Subtracao", new SubtracaoBusiness(instancia));
            ListaRegras.Add("Multiplicacao", new MultiplicacaoBusiness(instancia));
       }
    }
}
