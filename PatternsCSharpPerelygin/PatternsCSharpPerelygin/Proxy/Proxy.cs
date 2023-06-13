﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Proxy
{
    // управляет доступом к другому объекту
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();
            _realSubject.Request();
        }
    }
}
