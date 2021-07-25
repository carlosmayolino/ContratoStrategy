namespace StrategyConsoleApp.Logic.Abstract
{
    public abstract class AbstractContratoEstrategy<Tinstance, TResult> where Tinstance : AbstractPOCOViewModel
    {
        protected AbstractContrato<Tinstance, TResult> Contrato { get; set; }
        protected Tinstance Instancia { get; set; }
        public TResult Result { get; set; }


        public AbstractContratoEstrategy(AbstractContrato<Tinstance, TResult> contrato, Tinstance instancia)
        {
            Contrato = contrato;
            Instancia = instancia;
            Contrato.IniciarContrato(instancia);
        }

      

        /// <summary>
        /// IMPLEMENTAR A LÓGICA PARA SELEÇÃO DA REGRA e PREENCHER O RETORNO DO CONTRADO.
        /// </summary>
        /// <returns></returns>
        public abstract bool Executar();

 
    }
}
