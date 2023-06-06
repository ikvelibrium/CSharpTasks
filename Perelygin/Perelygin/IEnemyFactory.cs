using System;
using System.Collections.Generic;
using System.Text;

namespace Perelygin
{
    interface IEnemyFactory
    {
        IEnemy[] Create();
    }
}
