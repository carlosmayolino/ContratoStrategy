using System.Collections.Generic;

namespace StrategyConsoleApp.Logic.Abstract
{
    public abstract class AbstractContrato<TInstance, TResult> where TInstance : AbstractPOCOViewModel
    {
       public Dictionary<object, AbstractRegra<TInstance, TResult>> ListaRegras { get; set; } = new Dictionary<object, AbstractRegra<TInstance, TResult>>();

        /// <summary>
        /// Adicione na 'ListaRegras' a chave de pesquisa e a respectiva implementação concreta da classe da regra a ser executada pelo Strategy
        /// </summary>
        /// <param name="instancia"></param>
        public abstract void IniciarContrato(TInstance instancia);

    }
}
