using StrategyConsoleApp.Logic.Abstract;

namespace StrategyConsoleApp.Logic.OperacaoTexto
{
    public class ContratoOperacaoTextoEstrategy : AbstractContratoEstrategy<OperacaoTextoPOCO, string>
    {

        public ContratoOperacaoTextoEstrategy(ContratoOperacaoTexto contrato, OperacaoTextoPOCO instancia) : base(contrato, instancia)
        {

        }
        public override bool Executar()
        {

            try
            {
                var regra = Contrato.ListaRegras[Instancia.Operacao];
                regra.Consistir();
                Result = $"{Instancia.Operacao}: {regra.Result}";

                return true;
            }
            catch (System.Exception)
            {
                Result = "Não foi possivel identificar a regra";
                return false;
                    
            }

        }
    }
}
