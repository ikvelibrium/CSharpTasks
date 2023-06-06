using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    class MiddleEnFactory : IEnemyFactory
    {
        public IEnemy[] Create()
        {
            Random rnd = new Random();
            return new IEnemy[] { new Bee(rnd.Next(1, 4), rnd.Next(15, 20)), new Wolf(rnd.Next(5, 8), rnd.Next(3, 5)) };
        }
    }
}
