//*********************************************************
//*Практическая работа №6                                 *
//*Выполнил:Алексеев Н.М., группа 2ИСП                    *
//*Задание:Составить программу работу линейного алгоритма *
//*********************************************************
using System;


namespace pr_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа № 5";// заголовок консоли
                                                      // 
            double x, x1, y, y1,S1,S2;// объявление переменных
            
            Console.WriteLine("Здравствуйте");
            Console.Write("Введите два числа: \n");
            try 
            {
                Console.Write("x = "); //ввод исходных данных
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("x1 = ");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y1 = ");
                y1 = Convert.ToInt32(Console.ReadLine());

                S1 = (x * y) / 4; //площадь 1 треугольника
                S2 = (x1 * y1) / 4; //площадь 2 треугольника
                switch (S1 > S2)
                {
                    case true:
                        {
                            Console.WriteLine("треугольник 1 больше треугольника 2");
                            break;
                        }

                    case false:
                        {
                            switch (S1 < S2)
                            {
                                case true:
                                    {
                                        Console.WriteLine("треугольник 2 больше треугольника 1");
                                        break;
                                    }
                                case false:
                                    {
                                        Console.WriteLine("треугольник 1 равен треугольнику 2");
                                        break;
                                    }
                            }
                            break;


                        }

                }
                Console.WriteLine($"Результат: v1 = {S1} Площадь треугольника 1");
                Console.WriteLine($"Результат: v2 = {S2} Площадь треугольника 2");
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("что то не так" + fe.Message);
            }
            catch (TypeLoadException TLE ) 
            {
                Console.WriteLine("сбой при загрузке" + TLE.Message);
            }
            catch (OutOfMemoryException Rum)
            {
                Console.WriteLine("Ваша память кончилась" + Rum.Message);
            }
            Console.ReadKey();// задержка экрана консоли

        }
    }
}
        
