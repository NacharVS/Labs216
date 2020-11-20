using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labs216.Tarskih.Strategy
{
    public enum UnitClass
    {
        Villager,
        Warrior,
        WarriorHealer,
        WarriorEngineer
    }
    class Villager
    {
        public int Health = 100;
        public int Armor = 10;
        public int Damage = 5;
        public int Speed = 5;
        public int Medicine = 1;
        public int Enginering = 1;
        public UnitClass unitClass;
    }
    class Warrior
    {
        public int Health = 100;
        public int Armor = 100;
        public int Damage = 20;
        public int Speed = 3;
        public int Medicine = 0;
        public int Enginering = 0;
        public UnitClass unitClass;
    }
    class WarriorHealer
    {
        public int Health = 100;
        public int Armor = 80;
        public int Damage = 10;
        public int Speed = 3;
        public int Medicine = 1;
        public int Enginering = 0;
        public UnitClass unitClass;
    }
    class WarriorEngineer
    {
        public int Health = 100;
        public int Armor = 70;
        public int Damage = 15;
        public int Speed = 2;
        public int Medicine = 0;
        public int Enginering = 1;
        public UnitClass unitClass;
    }
    class CommonNearWeapon
    {
        public int Damage = 50;
        public int Durability = 200;
    }
    class UncommonNearWeapon
    {
        public int Damage = 60;
        public int Durability = 240;
    }
    class CommonArmor
    {
        public int Armor = 100;
        public int Durability = 500;
    }
    class UncommonArmor
    {
        public int Armor = 120;
        public int Durability = 600;
    }
}