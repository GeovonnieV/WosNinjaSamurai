using System;

namespace WosNinjaSamurai
    {

        class Ninja : Human
            {
                public int Dexterity;
                public Ninja(string Name)
                    : base(Name)
                    {
                        Dexterity = 175;
                    }

                    public override int Attack(Human target)
                        {
                            int damage = 5 * Dexterity;
                            target.health -= damage;
                            Random rand = new Random();
                            int randomNum = rand.Next(0,100);
                            if(randomNum <= 20)
                                {
                                    target.health -= 10;
                                }

                            return target.health;
                        }

                        public int Steal(Human target)
                            {
                                target.health -= 5;
                                System.Console.WriteLine("targets" + target.health);
                                health += 5;
                                System.Console.WriteLine("Ninja: " + health);
                                return Health;
                            }

            }
        
    }