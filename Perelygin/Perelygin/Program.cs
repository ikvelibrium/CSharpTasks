using System;

namespace Perelygin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Если хотите сложную волну нажмите 1, среднюю 2, сложную 3");
            int a = int.Parse(Console.ReadLine());
            IEnemyFactory fact = null;
            switch(a)
            {
                case 1 : fact = new EasyEnFactory();
                    break;
                case 2:
                    fact = new MiddleEnFactory();
                    break;
                case 3:
                    fact = new HardEnFactory();
                    break;
            }

            IEnemy[] wave = fact.Create();
            for (int i = 0; i < wave.Length; i++)
            {
                wave[i].DealDamage();
            }
        }
    }
}

