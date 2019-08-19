using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //алгоритм для перетасовки колоды к проекту "1000"(Action Script 3.0+Player.IO(C#)+VK.API)
        //происходит создание случайной колоды состоящей из 24 карт (от девяток до туза). Номера карт учтены в проекте "1000"
        //без повторений значений
        static void Main(string[] args)
        {
            int[] koloda0 = new int[24]; //массив чисел
            bool test = true; //статус перебора чисел
            Random rand = new Random();
            koloda0[0] = rand.Next(0, 24); //задаём первое значение массива
            Console.Write(koloda0[0]);

            for (int i = 1; i < 24; i++)
            {

                koloda0[i] = rand.Next(0, 24);
                //пока статус true, переписываем числа, до появления числа, которое не повторяется
                while (test)
                {
                    int count = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (koloda0[i] == koloda0[j])
                        {
                            koloda0[i] = rand.Next(0, 24);
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (count == i)
                    {
                        test = false;
                    }
                }
                test = true;
                Console.Write(" " + koloda0[i]);
            }
            Console.ReadKey();
        }
    }
}
