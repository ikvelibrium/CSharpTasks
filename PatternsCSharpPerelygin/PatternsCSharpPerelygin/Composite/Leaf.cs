using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsCSharpPerelygin.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void Display()
        {
            System.Console.WriteLine(_name);
        }
        public override void AddComponent(Component component)
        {
        }
        public override void Remove(Component component)
        {
        }
    }
}
