using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Composite
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Display();
        public abstract void AddComponent(Component component);
        public abstract void Remove(Component component);
    }
}
