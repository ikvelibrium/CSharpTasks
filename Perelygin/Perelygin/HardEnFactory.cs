using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    class HardEnFactory : IEnemyFactory
    {
        public IEnemy[] Create()
        {
            Random rnd = new Random();
            return new IEnemy[] { new Bee(rnd.Next(1, 6), rnd.Next(20, 25)), new Wolf(rnd.Next(10, 15), rnd.Next(6, 11)), new Bear(rnd.Next(10, 20), rnd.Next(1, 10)) };
        }
    }
}
