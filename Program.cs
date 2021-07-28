using System;

namespace WosNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
           Wizard dana = new Wizard("dana");
           Human bob = new Human("bob");
           Ninja bobs = new Ninja("bobs");
           bobs.Steal(bob);
        //    dana.getInfo();
           dana.Attack(bob);
        }
    }
}
