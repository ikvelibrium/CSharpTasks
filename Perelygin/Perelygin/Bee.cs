using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    class Bee : IEnemy
    {
        public int Damage { get; set; }
        public int Amount { get; set; }

        public void DealDamage()
        {
            Console.WriteLine($"{Amount} of bees dealed {Damage} dmg");
        }
        public Bee(int damage, int amount)
        {
            Damage = damage;
            Amount = amount;
        }
    }
}
