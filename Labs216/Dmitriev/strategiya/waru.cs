using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya
{
    class waru
    {
        sealed class pblcapi : Infa,IMovable
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public string UnitType { get; } = "земля ";

            public pblcapi(int zdorove, int oborona, double speed, int uron)
            {
                Health = zdorove;
                Defense = oborona;
                Speed = speed;
                Damage = uron;
            }

            public void Attack()
            {
                Console.WriteLine($"наносит урон: {Damage}");
            }

            public void Move()
            {
                Console.WriteLine($" {UnitType} скорость: {Speed}");
            }
        }

        
            
        sealed class lodka : Infa, IMovable, IShootable
            public void Shoot()
            {
                Console.WriteLine($": {ShootDamage}");
            }
        }

        sealed class pexota :  IMovable
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public string UnitType { get; } = "земля";

            public pexota(int zdorove, int oborona, double speed, int uron)
            {
                Health = zdorove;
                Defense = oborona;
                Speed = speed;
                Damage = uron;
            }

            public void Attack()
            {
                Console.WriteLine($"ehjy: {Damage}");
            }

            public void Move()
            {
                Console.WriteLine($" направление  {UnitType}  скорость: {Speed}");
            }
    }
    
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public string UnitType { get; } = "water";
            public int Distance { get; private set; }
            public int ShootDamage { get; private set; }

            public lodka(int zdorove, int oborona, double speed, int uron)
            {
                Zdorove = zdorove;
                Defense = oborona;
                Speed = speed;
                Damage = uron;
            }

                public void Attack()
                {
                    Console.WriteLine($"урон: {Damage}");
                }

                public void Move()
                {
                    Console.WriteLine($" {UnitType}скорость : {Speed}");
                }

                public void Shoot()
                {
                    Console.WriteLine($": {ShootDamage}");
                }
            }

            sealed class samolet : Infa, IMovable, IShootable
            {
                public int Damage { get; private set; }
                public double Speed { get; private set; }
                public string UnitType { get; } = "воздух";
                public int Distance { get; private set; }
                public int ShootDamage { get; private set; }

                public samolet(int zdorove, int oborona, double speed, int uron)
                {
                    Health = zdorove;
                    Defense = oborona;
                    Speed = speed;
                    Damage = uron;
                }

                public void Attack()
                {
                    Console.WriteLine($"урон: {Damage}");
                }

                public void Move()
                {
                    Console.WriteLine($"двигатся  {UnitType} скорость: {Speed}");
                }

            } 


