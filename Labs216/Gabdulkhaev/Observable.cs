using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class Observable
    {
        public static void Obser_vable()
        {
            ObservableCollection<Bank> bankeers = new ObservableCollection<Bank>
            {
                new Bank("Имя", "Фамилия",20,1,new DateTime(2000,1,1)),
                new Bank("Имя", "Фамилия",10,2,new DateTime(1990,2,12))
            };
            bankeers.Add(new Bank("Имя", "Фамилия", 10, 3, new DateTime(1913, 10, 20)));
            bankeers.Add(new Bank("Имя", "Фамилия", 40, 4, new DateTime(1950, 12, 12)));
            //     bankeers.CollectionChanged +=;
            bankeers.Add(new Bank("Имя", "Фамилия", 40, 4, new DateTime(1950, 12, 12)));
            bankeers.Add(new Bank("Имя", "Фамилия", 40, 4, new DateTime(1950, 12, 12)));
            bankeers.Add(new Bank("Имя", "Фамилия", 40, 4, new DateTime(1950, 12, 12)));
            bankeers.RemoveAt(3);
        }
        //static void BankCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    switch ()
        //    {
        //        case 
        //            break;
        //            case
        //            break;
        //            case
        //            break;
            }
        }
    }
}
