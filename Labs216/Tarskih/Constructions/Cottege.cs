using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih.Constructions
{
    public class Cottage : Abstract_Classes.ConstructionData, Interfaces.ICRestingPlace, Interfaces.ICSafeKeeping, Interfaces.ICGettingDamagePlace, Interfaces.ICDefendingPlace, Interfaces.ICRestorationPlace, Interfaces.ICDestruction // --------------------------------------------------- Хижина
        {
            public Cottage(int x, int y, int durability, int place_count, int rest_place_count, bool resting_place, bool defending_place, string description_construction, int restoration_place, int current_material_count_place, int max_material_count_place, int take_material_count_place, int getting_damage_place, int max_durability)
            {
                X = x;
                Y = y;
                Durabilty = durability;
                PlaceCount = place_count;
                RestPlaceCount = rest_place_count;
                RestingPlace = resting_place;
                DefendingPlace = defending_place;
                DescriptionConstruction = description_construction;
                RestorationPlace = restoration_place;
                TakeMaterialCountPlace = take_material_count_place;
                MaxMaterialCountPlace = max_material_count_place;
                CurrentMaterialCountPlace = current_material_count_place;
                GettingDamagePlace = getting_damage_place;
                MaxDurabilty = max_durability;
            }
            public void CRestingPlace(int a)
            {
                if (RestingPlace)
                {
                    if (RestPlaceCount != 0)
                    {
                        Console.WriteLine("В этой хижине есть место для отдыха. Занять его? ( да = 1, нет = 2)");
                        if (a == 1)
                        {
                            RestPlaceCount = RestPlaceCount - 1;
                            Console.WriteLine("В этой хижине было занято место для отдыха");
                        }
                        else if (a == 2)
                        {
                            RestPlaceCount = RestPlaceCount;
                            Console.WriteLine("В этой хижине не было занято место для отдыха");
                        }
                    }
                    else
                    {
                        Console.WriteLine("В этой хижине нет свободных мест для отдыха");
                    }
                }
                else
                {
                    Console.WriteLine("В этой хижине не может быть мест для отдыха");
                }
            }
            public void CDefending()
            {
                if (DefendingPlace)
                {
                    Console.WriteLine("С этой хижины может осуществляться защита");
                }
            }
            public void CGettingDamage()
            {
                if (GettingDamagePlace != 0)
                {
                    Durabilty = Durabilty - GettingDamagePlace;
                    Console.WriteLine("Эта хижина получает урон");
                }
                else
                {
                   
                }
            }
            public void CDestruiction()
            {
                if (Durabilty <= 0)
                {
                    Console.WriteLine("Эта хижина разрушена");
                }
                else
                {
                    Console.WriteLine("Эта хижина не разрушено");
                }
            }
            public void CRestoration(int b)
            {
                if (Durabilty !<= 0)
                {
                    Console.WriteLine("Эта хижина может быть восстановлено ( да = 1, нет = любая клавиша)");
                    if (b == 1)
                    {
                        if (Durabilty != MaxDurabilty)
                        {
                            Durabilty = Durabilty + RestorationPlace;
                            Console.WriteLine($"Эта хижина восстанавливается на {RestorationPlace} единиц");
                        }
                        else
                        {
                            Console.WriteLine("Эта хижина не требуется в восстановлении");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Был выбран вариант не восстанавливать хижину");
                    }
                }
                else
                {
                    Console.WriteLine("Эта хижина не может быть восстановлена, так как она уничтожена");
                }
            }
            public void CSafeKeeping(int c)
            {
                if (CurrentMaterialCountPlace != MaxMaterialCountPlace)
                {
                    Console.WriteLine("Сложить в эту хижину материал? ( да = 1, нет = любая клавиша");
                    if (c == 1)
                    {
                        CurrentMaterialCountPlace = CurrentMaterialCountPlace + TakeMaterialCountPlace;
                        Console.WriteLine($"В эту хижину было вложено {TakeMaterialCountPlace} материала");
                    }
                    else
                    {
                        Console.WriteLine("В хижину не было вложен материал");
                    }
                }
                else
                {
                    Console.WriteLine("Хранилище в хижине переполнено! Она не может получить больше материала!");
                }
            }
        }
}
