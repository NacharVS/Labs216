using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov
{
    class CalculationMethods
    {
        public static void Calculator()
        {
            while (true)
            {
                Console.WriteLine("Дискриминат-1");
                Console.WriteLine("Теорема Пифагора-2");
                Console.WriteLine("Длина окружности-3");
                Console.WriteLine("Площадь круга-4");
                Console.WriteLine("Объем параллелепипеда-5");
                Console.WriteLine("Сила тока/Напряжение/Сопротивление через друг друга");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Нахождение дискримината");
                        Console.WriteLine("Введите a");
                        int one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите b");
                        int two = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите c");
                        int three = Convert.ToInt32(Console.ReadLine());
                        int discr = -two / 2 * one;
                        int x_one = (-two + discr) / 2 * one;
                        int x_two = (-two - discr) / 2 * one;
                        Console.WriteLine($"x1 = {x_one},x2 = {x_two}");
                        break;
                    case 2:
                        Console.WriteLine("Теорема пифагора");
                        Console.WriteLine("Что вы хотите найти? Гипотенузу - 1, катет треугольника - 2");
                        int pifagor = Convert.ToInt32(Console.ReadLine());
                        switch (pifagor)
                        {
                            case 1:
                                Console.WriteLine("Введите первый катет треугольника");
                                double storona_1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите второй катет треугольника");
                                double storona_2 = Convert.ToDouble(Console.ReadLine());
                                double gipoten = Math.Pow(storona_1, 2) + Math.Pow(storona_2, 2);
                                Console.WriteLine($"Гипотенуза равна {gipoten}");
                                break;

                        }
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали вычисление длины окружности");
                        Console.WriteLine("Для вычисления длины окружности есть две формулы, что у вас дано? Диаметр или радиус? Диаметр - 1, Радиус - 2");
                        int dlina = Convert.ToInt32(Console.ReadLine());
                        switch (dlina)
                        {
                            case 1:
                                Console.WriteLine("Введите диаметр");
                                int diam = Convert.ToInt32(Console.ReadLine());
                                double dlina_1 = Math.PI * diam;
                                Console.WriteLine($"Длина окружности равна {dlina_1}");
                                break;
                            case 2:
                                Console.WriteLine("Введите радиус");
                                int radi = Convert.ToInt32(Console.ReadLine());
                                double dlina_2 = 2 * Math.PI * radi;
                                Console.WriteLine($"Длина окружности равна {dlina_2}");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали вычисление площади круга");
                        Console.WriteLine("Введите радиус");
                        double radiuss = Convert.ToInt32(Console.ReadLine());
                        double ploshad = Math.PI * Math.Pow(radiuss, 2);
                        Console.WriteLine($"Площадь круга равна {ploshad}");
                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали вычисление объема параллелепипеда");
                        Console.WriteLine("Есть две формулы для вычисления объема параллелепипеда: по площади основания, умноженной на высоту(1), и по трем сторонам(2), выберите одну из них");
                        int obiem = Convert.ToInt32(Console.ReadLine());
                        switch (obiem)
                        {
                            case 1:
                                Console.WriteLine("Введите высоту параллелепипеда");
                                double visota = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите плошадь основания параллелепипеда");
                                double plossssad = Convert.ToDouble(Console.ReadLine());
                                double obieeeeem_1 = visota * plossssad;
                                Console.WriteLine($"Объем параллелепипеда равен {obieeeeem_1}");
                                break;
                            case 2:
                                Console.WriteLine("Введите первое ребро параллелепипеда");
                                double rebro_1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите второе ребро параллелепипеда");
                                double rebro_2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите третье ребро параллелепипеда");
                                double rebro_3 = Convert.ToDouble(Console.ReadLine());
                                double obieeeeeeeeeeem_2 = rebro_1 * rebro_2 * rebro_3;
                                Console.WriteLine($"Объем параллелепипеда равен {obieeeeeeeeeeem_2}");
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Вы выбрали вычисление силы тока/напряжения/сопротивления");
                        Console.WriteLine("Что вы хотите вычислить? Сила тока - 1, Напряжение - 2, Сопротивление - 3");
                        int vibor = Convert.ToInt32(Console.ReadLine());
                        switch (vibor)
                        {
                            case 1:
                                Console.WriteLine("Вы выбрали вычисление силы тока");
                                Console.WriteLine("Введите напряжение");
                                double napr = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите сопротивление");
                                double soprot = Convert.ToDouble(Console.ReadLine());
                                double sila = napr / soprot;
                                Console.WriteLine($"Сила тока равна {sila}");
                                break;
                            case 2:
                                Console.WriteLine("Вы выбрали вычисление напряжения");
                                Console.WriteLine("Введите силу тока");
                                double silatoka = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите сопротивление");
                                double sopr = Convert.ToDouble(Console.ReadLine());
                                double napryazh = silatoka * sopr;
                                Console.WriteLine($"Напряжение равно {napryazh}");
                                break;
                            case 3:
                                Console.WriteLine("Вы выбрали вычисление сопротивления");
                                Console.WriteLine("Введите силу тока");
                                double sila_toka = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите напряжение");
                                double nap = Convert.ToDouble(Console.ReadLine());
                                double sop = nap / sila_toka;
                                Console.WriteLine($"Сопротивление равно {sop}");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильное число, попробуйте еще раз");
                        break;
                }
                Console.WriteLine("Если хотите перезагрузить калькулятор нажмите или напишите что угодно, если хотите закрыть его напишите close");
                if (Console.ReadLine() == "close")
                    return;

            }
        }


    }
}
