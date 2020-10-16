﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab1
{
    class Program
    {        
        static void Main(string[] args)
        {
            ConsoleUI ui = new ConsoleUI();            
            ui.AddItem("лабораторная 1", Lab1);            
            ui.startDrawMenu();
        }

        static public void Lab1()
        {

            bool exit = true;
            string _switch;

            while (exit)
            {
                Console.Write("Зададим размерность массива: ");

                int[] mass = new int[Convert.ToInt32(Console.ReadLine())];

                Console.Write("Создать массив автоматически? ( y [да] / n [нет] ): ");

                _switch = Console.ReadLine();

                if (_switch == "y")
                {
                    Random rand = new Random();

                    for (int i = 0; i < mass.Length; i++)
                    {
                        mass[i] = rand.Next(-10, 10);

                        Console.WriteLine($"| i:{i,3} = {mass[i],-6}|");
                    }

                }
                else
                {
                    Console.WriteLine("Ручнная иницилизация массвиа: ");

                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write($"Элемент [{i}] равен: ");

                        mass[i] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"| i:{i,3} = {mass[i],-6}|");
                    }
                }

                Console.Write("Осуществить поиск? ( y [да] / n [нет] ):");

                _switch = Console.ReadLine();

                if (_switch == "y")
                {
                    string[] answer = new string[1];

                    Console.Write("Искомое число = ");

                    answer = Algorithms.SimpleSearch(mass, Convert.ToInt32(Console.ReadLine()));

                    if (answer != null)
                    {
                        Console.WriteLine($"Результат: | i:{answer[0],3} v = {answer[1],-5}|");
                    }
                    else Console.WriteLine("Результат: null");
                }

                Console.WriteLine("Выполним сортировку массива с помощию алгоритма \"Сортирвка вставками\"");

                int index = 0;
                Console.Write("Выполнить сортировку по возрастанию? ( y [да] / n [нет] ):");

                _switch = Console.ReadLine();

                if (_switch == "y")
                {
                    foreach (int i in Algorithms.Insertion_Sort(mass))
                    {
                        Console.WriteLine($"| i:{index++,3} = {i,-6}|");
                    }
                }

                if (_switch == "n")
                {
                    foreach (int i in Algorithms.Insertion_Sort(mass, false))
                    {
                        Console.WriteLine($"| i:{index++,3} = {i,-6}|");
                    }
                }

                Console.Write("Прекратить выполнение программы? ( y [да] / __ [пропуск - программа продолжит работу]):");

                _switch = Console.ReadLine();

                if (_switch == "y") exit = false;
            }
        }
    }
}
