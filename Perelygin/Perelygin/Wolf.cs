using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    class Wolf : IEnemy
    {
        public int Damage { get; set; }
        public int Amount { get; set; }

        public void DealDamage()
        {
            Console.WriteLine($"{Amount} of wolves dealed {Damage} dmg");
        }
        public Wolf(int damage, int amount)
        {
            Damage = damage;
            Amount = amount;
        }
    }
}
