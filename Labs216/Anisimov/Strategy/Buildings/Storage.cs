using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov.Strategy.Buildings
{
    sealed class Storage : Characteristic, IInteractive, IStorage
    {
        int _gold;
        int _wood;
        int _food;

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = _gold + value <= MaxAmount
                    ? _gold + value
                    : MaxAmount;
            }
        }
        public int Wood
        {
            get { return _wood; }
            set
            {
                _wood = _wood + value <= MaxAmount
                    ? _wood + value
                    : MaxAmount;
            }
        }
        public int Food
        {
            get { return _food; }
            set
            {
                _food = _food + value <= MaxAmount
                    ? _food + value
                    : MaxAmount;
            }
        }
        public int MaxAmount { get; private set; }

        public Storage(int health, int defense, int maxamount)
        {
            Health = health;
            Defense = defense;
            MaxAmount = maxamount;
        }

        public void Interact()
        {
            Console.WriteLine($"You see a storage.\nGold: {Gold}/{MaxAmount}\nWood: {Wood}/{MaxAmount}\nFodd: {Food}/{MaxAmount}");
        }
    }
}
