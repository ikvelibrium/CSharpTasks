using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Bridge
{
    // позволяет отделить абстракцию от реализации таким образом, чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга
    public class Abstraction
    {
        public Implementor Implementor;

        public Abstraction(Implementor implementor)
        {
            Implementor = implementor;
        }

        public virtual void Operation() { }
    }
}
