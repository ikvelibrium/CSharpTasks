using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    class EasyEnFactory : IEnemyFactory
    {
        public IEnemy[] Create()
        {
            Random rnd = new Random();
            return new IEnemy[] { new Bee(rnd.Next(1, 3), rnd.Next(10, 15)) };
        }
    }
}
