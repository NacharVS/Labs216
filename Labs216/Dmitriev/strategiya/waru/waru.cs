using Labs216.Dmitriev.strategiya.Infa;
using Labs216.Dmitriev.strategiya.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.strategiya.waru
{
    
    class waru
    {
        sealed class pblcapi : infaBuilding, IMovable
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public string UnitType { get; } = "земля ";

            public pblcapi(int zdorove, int oborona, double speed, int uron)
            {
                _Zdorove = zdorove;
                _Oborona = oborona;
                Speed = speed;
                _uron = uron;
            }

            public void Attack()
            {
                Console.WriteLine($"наносит урон: {_uron}");
            }

            public void Move()
            {
                Console.WriteLine($" {UnitType} скорость: {Speed}");
            }
        }





        sealed class pexota : infa4ela 
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public string UnitType { get; } = "земля";

            public pexota(int zdorove, int oborona, double speed, int uron)
            {
                _Zdorove = zdorove;
                _Oborona = oborona;
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

        sealed class Lodka : infa4ela


             public lodka(int zdorove, int oborona, double speed, int uron)
        {
            _Zdorove = zdorove;
            _Oborona = oborona;
            _Speed = speed;
            _uron = uron;
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

    sealed class samolet : infa4ela, IMovable, IShootable
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


