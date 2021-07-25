using System;

namespace StrategyConsoleApp.Logic.Abstract
{
    public abstract class AbstractRegra<TInstance, TResult> where TInstance : AbstractPOCOViewModel
    {
        protected TInstance Instancia;
        public TResult Result;

        public AbstractRegra(TInstance instancia)
        {
            Instancia = instancia;
        }

        public abstract void Consistir();

    }
}
