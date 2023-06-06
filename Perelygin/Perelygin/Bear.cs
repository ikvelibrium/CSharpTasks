using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    class Bear : IEnemy
    {
        public int Damage { get; set; }
        public int Amount { get; set; }

        public void DealDamage()
        {
            Console.WriteLine($"{Amount} of bears dealed {Damage} dmg");
        }
        public Bear(int damage, int amount)
        {
            Damage = damage;
            Amount = amount;
        }
    }
}
