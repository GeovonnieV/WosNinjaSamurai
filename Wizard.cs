using System;

namespace WosNinjaSamurai
{

    class Wizard : Human
    {
        public int Health;
        public int Intelligence;
        public Wizard(string Name)
            : base(Name)
        {
            Health = 50;
            Intelligence = 25;
        }

        public void getInfo()
        {
            System.Console.WriteLine(Health + ": " + Intelligence);
        }

        public override int Attack(Human target)
        {
            int damage = 5 * Intelligence;
            target.health -= damage;
            Health += damage;
            return target.health;
        }

        public int Heal(Human target)
            {
                target.health += 10 * Intelligence;
                return target.health;
            }

    }


}