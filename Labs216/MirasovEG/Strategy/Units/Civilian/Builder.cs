﻿using System;

namespace Labs216.MirasovEG.Strategy.Units.Civilian
{
    class Builder : CharacteristicPerson, IMovable, IAttack
    {
        public Builder(int health, int defence, int dmg, int speed)
        {
            _health = health;
            _defense = defence;
            _DMG = dmg;
            _speed = speed;
        }
        public void MeleeAttack()
        {
            Console.WriteLine($"Builder attack: {_DMG}");
        }
        public void Move()
        {
            Console.WriteLine($"Builder move with speed: {_speed}");
        }

    }
}
