using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Adapter
{
    public class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
}
