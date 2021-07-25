using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.PesquisaEnum
{
    public class ContratoPesquisa : AbstractContrato<PesquisaEnumPOCO, string>
    {

        public override void IniciarContrato(PesquisaEnumPOCO pesquisa)
        {
            ListaRegras.Add(PesquisaEnum.Tipo.Pesquisa01, new Regra01(pesquisa));
            ListaRegras.Add(PesquisaEnum.Tipo.Pesquisa02, new Regra02(pesquisa));
        }



    }
}
