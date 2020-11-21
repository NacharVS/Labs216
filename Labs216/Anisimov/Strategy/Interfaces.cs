using System;

namespace Labs216.Anisimov.Strategy
{
    interface IMovable
    {
        public double Speed { get; }
        public string UnitType { get; }

        public void Move()
        {
            Console.WriteLine($"Unit move in the {UnitType} with speed: {Speed}");
        }
    }

    interface IShootable
    {
        public int ShootDamage { get; }
        public int Distance { get; }

        public void Shoot()
        {
            Console.WriteLine($"Unit shoot on distance -- {Distance} -- with damage: {ShootDamage}");
        }
    }


    interface IWorkable
    {
        public string Profesion { get; }

        public void Work()
        {
            Console.WriteLine($"Unit work. He if {Profesion}");
        }
    }
    
    interface IAttack
    {
        public int Damage { get; }
        public string AttackType { get; }

        public void Attack()
        {
            Console.WriteLine($"Unit attack with {AttackType} damage: {Damage}");
        }
    }

    interface IInteractive
    {
        public void Interact()
        {
            Console.WriteLine($"There is nothing interesting here");
        }
    }

    interface IGather //Один интерфейс для добытчика, источника и хранилиша ресурсов
    {
        public int Count { get; set; }
        public string GatherType { get; }

        public void Gather(IGather source)
        {
            if (GatherType == source.GatherType || source.Count != 0)
            {
                Count += 1;
                source.Count -= 1;
                Console.WriteLine($"Source : {source.Count}");
                Console.WriteLine($"Gatherer : {Count}");
            }
            else Console.WriteLine("You can't do this");
        }

        public void Store(IGather vault)
        {
            if (GatherType == vault.GatherType || Count != 0)
            {
                Count -= 1;
                vault.Count += 1;
                Console.WriteLine($"Vault : {vault.Count}");
                Console.WriteLine($"Gatherer : {Count}");
            }
            else Console.WriteLine("You can't do this");
        }
    }
}
