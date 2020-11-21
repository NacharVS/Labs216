
namespace Labs216.MirasovEG.Strategy.Units.Buildings
{
    public class WareHouse : CharacteristicBuilding
    {
        public WareHouse(int health, int defence)
        {
            _health = health;
            _defense = defence;
        }

        private int ResourcesWheat { get; set; }
        public void AddWheat(int wheat)
        {
            ResourcesWheat += wheat;
        }

        private int ResourcesWood { get; set; }
        public void AddWood(int wood)
        {
            ResourcesWood += wood;
        }

        private int ResourcesOre { get; set; }
        public void AddOre(int ore)
        {
            ResourcesOre += ore;
        }

        private int ResourcesCoin { get; set; }
        public void AddCoin(int coin)
        {
            ResourcesCoin += coin;
        }
    }
}
