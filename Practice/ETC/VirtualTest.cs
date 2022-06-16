using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ETC.VirtualTest
{
    class Monster
    {
        public virtual void Attack()
        {
            Console.WriteLine("Attack");
        }
    }

    class Slime : Monster
    {
        public override void Attack()
        {
            Console.WriteLine("Slime Attack");
        }
    }

    class Orc : Monster
    {
        public new void Attack()
        {
            Console.WriteLine("Orc Attack");
        }
    }

    class Dragon : Monster
    {
        public new void Attack()
        {
            Console.WriteLine("Dragon Attack");
        }
    }

    class Test
    {
        public static void Main1()
        {
            Monster slime = new Slime();
            Monster orc = new Orc();
            Monster dragon = new Dragon();

            slime.Attack();
            //Orc1? orc1 = orc as Orc1;
            orc.Attack();
            //Dragon1? dragon1 = dragon as Dragon1;
            dragon.Attack();
        }
    }
}
