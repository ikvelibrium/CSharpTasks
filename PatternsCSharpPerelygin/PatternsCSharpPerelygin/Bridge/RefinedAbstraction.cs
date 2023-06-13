using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Bridge
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor) { }

        public override void Operation()
        {
            Implementor.OperationImp();
        }
    }
}
