namespace Labs216.Anisimov.Strategy
{
    interface IMovable
    {
        public double Speed { get; }
        public string UnitType { get; }

        public void Move();
    }

    interface IShootable
    {
        public int ShootDamage { get; }
        public int Distance { get; }

        public void Shoot();
    }


    interface IWorkable
    {
        public void Work();
    }
    
    interface IAttack
    {
        public int Damage { get; }

        public void Attack();
    }

    interface IInteractive
    {
        public void Interact();
    }
}
