using System;

namespace WosNinjaSamurai
    {
        class Samurai : Human
         {
            public int Health;
             public Samurai(string Name)
                :base(Name)
                    {
                        Health = 200;
                    }

             public override int Attack(Human target)
                {
                    target.Attack(target);
                    if(target.health < 50)
                        {
                            target.health = 0;
                        }
                    return target.health;
                }

                public int Meditate()
                    {
                        if(Health < 200)
                            {
                                Health = 200;
                            }
                        return Health;
                    }

         }

    }