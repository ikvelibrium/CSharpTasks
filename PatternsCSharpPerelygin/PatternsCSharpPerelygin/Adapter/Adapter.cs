using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Adapter
{
    // предназначен для преобразования интерфейса одного класса в интерфейс другого
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
