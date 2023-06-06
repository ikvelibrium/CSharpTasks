using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    public interface IEnemy
    {
        int Damage { get; set; }

        int Amount { get; set; }
        void DealDamage();
    }
}
