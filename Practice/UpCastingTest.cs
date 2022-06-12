using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public void Stress()
    {
        Console.WriteLine("Stress");
    }
}

class MonsterSpawn
{
    public void Spawn(Monster monster)
    {
        Console.WriteLine("Spawn");
        
        if(monster is Slime)
        {
            Slime? slime = monster as Slime;
            slime?.Attack();
            slime?.Stress();
        }
    }
}


class UpCastingTest
{
    public static void Main1()
    {
        Slime slime = new Slime();
        MonsterSpawn monsterSpawn = new MonsterSpawn();
        monsterSpawn.Spawn(slime);
    }
}
