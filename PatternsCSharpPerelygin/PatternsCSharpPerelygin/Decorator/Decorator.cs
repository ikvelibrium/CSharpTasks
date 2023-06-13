﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Decorator
{
    // позволяет динамически подключать к объекту дополнительную функциональность
    public abstract class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component?.Operation();
        }
    }
}
