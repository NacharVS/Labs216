namespace Labs216.MirasovEG.Strategy
{
    public abstract class CharacteristicPerson
    {
        public int _health { get; set; }
        public int _defense{ get;  set; }
        public int _DMG { get;  set; }
        public int _speed { get;  set; }
    }

    public abstract class CharacteristicBuilding
    {
        public int _health { get;  set; }
        public int _defense { get;  set; }
        public int _dmgBuild { get; set; }
    }
}
