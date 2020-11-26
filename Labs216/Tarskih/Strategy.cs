using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Labs216.Tarskih
{
    public class Strategy // Интерфейсы
    {
        interface IChoice // Интерфейс выбора
        {
            public int Choice { get; set; }
        }

        interface IMoving // Интерфейс движения
        {
            public int X { get; set; }
            public int Y { get; set; }
        }



        interface IDamaging // Интерфейс нанесения урона
        {
            public int ValueOfDamaging { get; set; }
        }



        interface IHealing // Интерфейс Лечения
        {
            public int ValueOfHealing { get; set; }
        }



        interface IMessaging // Интерфейс передачи сообщения
        {
            public string CurrentMessage { get; set; }
        }



        interface IInsiding // Интерфейс нахождения внутри
        {
            public string ObjectWithPlace { get; set; }
            public string SubjectInto { get; set; }
        }



        interface IVehicle // Интерфейс Транспорта
        {
            public string NameOfVehicle { get; set; }
            public int VehicleSpeed { get; set; }
            public int SeatCount { get; set; }
            public int ValueGas { get; set; }
            public int VehicleDurabilty { get; set; }
        }



        interface IBuilding // Интерфейс Здания
        {
            public string NameOfBuilding { get; set; }
            public int MaterialCount { get; set; }
            public int MaterialFeatured { get; set; }
            public int EntityCount { get; set; }
            public int BuildingDurability { get; set; }
        }



        interface ICharacteristics // Интерфейс Характеристик
        {
            public int Health { get; set; }
            public int Speed { get; set; }
            public int DamageAbsolute { get; set; }
        }



        interface IArmor // Интерфейс Брони
        {
            public int ArmorAbsolute { get; set; }
            public int ArmorDurabilty { get; set; }
        }



        interface IWeapon // Интерфейс Оружия
        {
            public int WeaponDamage { get; set; }
            public int WeaponDurability { get; set; }
            public int WeaponDistance { get; set; }
        }



        interface IDescription // Описание
        {
            public string DescriptionEntity { get; set; }
        }



        public class Villager : IMoving, ICharacteristics, IDamaging, IDescription, IHealing
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Health { get; set; }
            public int Speed { get; set; }
            public int ValueOfHealing { get; set; }
            public int DamageAbsolute { get; set; }
            public int ValueOfDamaging { get; set; }
            public string DescriptionEntity { get; set; }

            public class VillagerA // Деревенский житель
            {
                public int X = 0;
                public int Y = 0;
                public int Health = 100;
                public int Speed = 5;
                public int ValueOfHealing = 10;
                public int DamageAbsolute = 10;
                public bool WeaponHave = false;
                public string DescriptionEntity = "Житель - обычный поселенец, являющийся частью населения деревни";
                public int DamageReal = 0;

                public void Moving(int X1, int Y1)
                {
                    int X = 0 + X1;
                    int Y = 0 + Y1;
                    Console.WriteLine($"Деревенский житель переместился на {X} и {Y}");
                }

                public void Attack()
                {
                    if (WeaponHave)
                    {
                        DamageReal = DamageReal + DamageAbsolute;
                        Console.WriteLine($"Деревенский житель наносит урон в {DamageReal} условных единиц");
                    }
                    else
                    {
                        Console.WriteLine($"Деревенский житель наносит урон в {DamageAbsolute} условных единиц");
                    }
                }
            }



            public class Guardian : IMoving, ICharacteristics, IDamaging, IDescription
            {
                public int X { get; set; }
                public int Y { get; set; }
                public int Health { get; set; }
                public int Speed { get; set; }
                public int DamageAbsolute { get; set; }
                public int ValueOfDamaging { get; set; }
                public string DescriptionEntity { get; set; }
                public class GuardianA : IronSword // Деревенский страж
                {
                    public int X = 0;
                    public int Y = 0;
                    public int Health = 100;
                    public int Speed = 5;
                    public int DamageAbsolute = 20;
                    public bool WeaponHave = false;
                    public string DescriptionEntity = "Деревенский страж способен дать отпор любому недругу, который представляет опасность для населения деревни";
                    public int DamageReal = 0;
                    public void WeaponHaving() // Деревенский страж взял в руки оружие
                    {
                        if (IronSwordHaving)
                        {
                            WeaponHave = true;
                            DamageReal = DamageReal + DamageIronSword;
                            Console.WriteLine("Деревенский страж взял в руки оружие");
                        }
                        else
                        {
                            WeaponHave = false;
                        }
                    }
                    public void Moving(int X1, int Y1)
                    {
                        int X = 0 + X1;
                        int Y = 0 + Y1;
                        Console.WriteLine($"Деревенский страж переместился на {X} и {Y}");
                    }

                    public void Attack()
                    {
                        if (WeaponHave)
                        {
                            DamageReal = DamageReal + DamageAbsolute;
                            Console.WriteLine($"Деревенский страж наносит урон в {DamageReal} условных единиц");
                        }
                        else
                        {
                            Console.WriteLine($"Деревенский страж наносит урон в {DamageAbsolute} условных единиц");
                        }
                    }
                }


                public class IronSword // Железный Меч
                {
                    public bool IronSwordHaving = true;
                    public int DamageIronSword = 25;
                    public int DurabilityIronSword = 500;
                }


                public class DiamondSword // Алмазный Меч
                {
                    public bool DiamondSwordHaving = true;
                    public int DamageIronSword = 40;
                    public int DurabilityIronSword = 750;
                }
            }
        }
    }
}
