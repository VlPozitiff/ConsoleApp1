using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char[,] arr = new char[,]
            {
                {'*','*','*'},
                {'*','*','*'},
                {'*','*','*'}
            };
            const int SIZE_X = 3;
            const int SIZE_Y = 3;
            const string GAMER_1_NAME = "Игрок 1";
            const string GAMER_2_NAME = "Игрок 2";
            const char X = 'x';
            const char O = 'o';
            const char DEFAULT_FIELD = '*';
            bool game = true;
            string gamer_name = GAMER_2_NAME;
            char current_sym = X;
            while (game)
            {   //наше игровое поле
                Console.WriteLine("  1 2 3");
                for (int i = 0; i < SIZE_Y; i++)
                {
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        if (j == 0) Console.Write(Convert.ToString(i + 1) + " ");
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                if (gamer_name == GAMER_1_NAME)
                {
                    gamer_name = GAMER_2_NAME;
                    current_sym = O;
                }
                else
                {
                    gamer_name = GAMER_1_NAME;
                    current_sym = X;
                }
                //цикл служит для постоянных проверок
                bool is_not_valid_enter = false;
                do
                {


                    Console.Write(gamer_name + " - Введите координаты поля:");
                    string stroke = Console.ReadLine().ToString();// вводим строку
                    string[] stroke_num = stroke.Split(' ');//получаем x y

                    if (arr[Convert.ToInt16(stroke_num[0]) - 1,
                        Convert.ToInt16(stroke_num[1]) - 1] == DEFAULT_FIELD)
                    {
                        is_not_valid_enter = false;
                        arr[Convert.ToInt16(stroke_num[0]) - 1, Convert.ToInt16(stroke_num[1]) - 1] = current_sym;
                    }
                    else
                    {
                        Console.WriteLine("В данном поле уже присутствует символ");
                        is_not_valid_enter = true;
                    }

                } while (is_not_valid_enter);

                if ((arr[0, 0] == X) && (arr[0, 1] == X) && (arr[0, 2] == X))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[1, 0] == X) && (arr[1, 1] == X) && (arr[1, 2] == X))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[2, 0] == X) && (arr[2, 1] == X) && (arr[2, 2] == X))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[0, 0] == X) && (arr[1, 1] == X) && (arr[2, 2] == X))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[2, 0] == X) && (arr[1, 1] == X) && (arr[0, 2] == X))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }

                if ((arr[0, 0] == O) && (arr[0, 1] == O) && (arr[0, 2] == O))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[1, 0] == O) && (arr[1, 1] == O) && (arr[1, 2] == O))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[2, 0] == O) && (arr[2, 1] == O) && (arr[2, 2] == O))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[0, 0] == O) && (arr[1, 1] == O) && (arr[2, 2] == O))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }
                else if ((arr[2, 0] == O) && (arr[1, 1] == O) && (arr[0, 2] == O))
                {
                    Console.WriteLine(arr);
                    Console.WriteLine($"Победитель: {gamer_name}");
                    break;
                }


            }



        }


    }

}





