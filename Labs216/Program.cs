namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            var archer1 = TeachArcher();
            IMovable move = archer1;
            move.Move();
            ISootable shoot = archer1;
            shoot.Shoot();
        }
        public static TeachArcher()
        {
            Archer archerUnit = new Archer;
            archerUnit.minDamage = 3;
            archerUnit.maxDamage = 7;
            return archerUnit;

        }
    }
}
