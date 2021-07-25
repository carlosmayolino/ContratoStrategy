using StrategyConsoleApp.Logic.Abstract;
using StrategyConsoleApp.Logic.PesquisaEnum;
using System;

namespace StrategyConsoleApp.Logic
{
    public class ContratoPesquisaEstrategy : AbstractContratoEstrategy<PesquisaEnumPOCO, string>
    {
       
        public ContratoPesquisaEstrategy(ContratoPesquisa contrato, PesquisaEnumPOCO pesquisa) : base(contrato, pesquisa)
        {
        }
        public override bool Executar()
        {
            try
            {
                var regra = Contrato.ListaRegras[Instancia.Escolha];

                regra.Consistir();
                Result = regra.Result;
                return true;
            }
            catch (Exception ex)
            {
               Result = "Não foi possível executar a pesquisa. Tente mais tarde.";
                //Aqui vai o log;
                //Log.Error(ex.Message);
                return false;
            }
        }
    }
}
