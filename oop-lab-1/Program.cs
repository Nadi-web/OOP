using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1
{
    class Program
    {

        static int CheckedFun()
        {
            int val1 = checked(2147483647);
            return val1;
        }
        static int UnCheckedFun()
        {
            int val2 = unchecked(2147483647 + 1);
            return val2;
        }
        static void Main(string[] args)
        {
            int[] numbers;
            string str;
            byte b = 3;
            byte b2 = 5;
            sbyte sb = 126;
            short s = 32;
            ushort sh = 31;
            int x = -1;
            int y = 2;
            uint ui = 44;
            long l = 678;
            ulong ul = 67890;
            double d = 2.3;
            decimal bankBalance = 53005.25M;
            float f = 1.1f;
            char myChar = default;
            string name = "Aloha";
            bool think = false;
            object obj1 = 1;
            var a = 1;
            Console.WriteLine(b);
            Console.WriteLine(sb);
            Console.WriteLine(s);
            Console.WriteLine(sh);
            Console.WriteLine(x);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(myChar);
            Console.WriteLine(name);
            Console.WriteLine(think);
            Console.WriteLine(obj1);
            Console.WriteLine(bankBalance);

            //неявные преобразования

            ushort c = b;
            short h = sb;
            int ireb = s;
            long g = x;
            double e = f;

            //явные преобразования

            byte z = (byte)(x + y);
            short t = (short)(b + b2);
            float o = (float)l;
            int n = (int)sb;
            long p = (long)ui;

            //Convert

            int q = Convert.ToInt32("23");

            //упаковка и распаков
            int rar = 1;
            object nan = rar;
            int pap = (int)nan;

            double bob = 1.123;
            object bab = bob;
            double bib = (double)bab;

            byte byt = 4;
            object bat = byt;
            byte bot = (byte)bat;

            //работа с неявно типизированно переменной
            var sub = 6458;
            var bus = 1;
            sub = sub + bus;
            Console.WriteLine(sub);

            //Nullable переменной
            int? val = null;
            Console.WriteLine(val);

            //сравнение строковых литералов
            string s1 = "my";
            string s2 = "note";
            int result = string.Compare(s1, s2);

            string r1 = "Saimor Dumcan pickup";
            string r2 = "Ibanez";
            string r3 = "pickup";

            //сцепление строк

            string r4 = r1 + " " + r2;
            Console.WriteLine(r4);

            //копирование строки

            string r5 = string.Copy(r3);
            Console.WriteLine(r5);

            //разделение строки на слова

            string[] manyst = r1.Split(' ');
            Console.WriteLine(manyst[0]);
            Console.WriteLine(manyst[1]);
            Console.WriteLine(manyst[2]);

            //вставка подстроки в заданную позицию

            Console.WriteLine(r2.Insert(2, "aaa"));

            //удаление заданной подстроки

            r1 = r1.Remove(0, 4);
            Console.WriteLine(r1);

            //интерполирование строк

            string test1 = $"{x} + {y} = {x + y}";
            Console.WriteLine(test1);

            //пустая и null строки
            string empty = null;
            string empty1 = "";
            Console.WriteLine("IsNullOrEmpty");
            bool IsNullOrEmpty = string.IsNullOrEmpty(empty1);
            Console.WriteLine(IsNullOrEmpty);

            //StringBuilder

            StringBuilder strhr = new StringBuilder("Hello World");
            Console.WriteLine(strhr.Remove(5, 3));
            Console.WriteLine(strhr.Append("TTT"));

            //двумерный массив
            int[,] matrix = {       //[строк] [столбцов], вывод как в плюсах 
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
            };

            for (int i = 0; i < matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < matrix.GetLength(0); ++j)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //одномерный массив строк

            string[] strArray = { "hgvujvk", "jtcch", "yitc", "ouih" };
            foreach (var item in strArray)
            {
                Console.Write('<' + item + "> ");
            }
            Console.WriteLine($"\nLength of the string array: {strArray.Length}");
            Console.WriteLine("Введите id элемента который хотите изменить");
            byte position = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение элемента {position}: ");
            strArray[position] = Console.ReadLine();
            foreach (var item in strArray)
            {
                Console.Write('<' + item + "> ");
            }
            Console.WriteLine();

            //ступечатый массив вещественных чисел

            Console.WriteLine("Enter values of float-based matrix down here:");

            float[][] fMatrix = new float[3][];
            fMatrix[0] = new float[2];
            fMatrix[1] = new float[3];
            fMatrix[2] = new float[4];
            for (int i = 0; i < fMatrix.Length; ++i)
            {
                for (int j = 0; j < fMatrix[i].Length; ++j)
                {
                    Console.Write($"Enter element [{i}][{j}]: ");
                    fMatrix[i][j] = float.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < fMatrix.Length; ++i)
            {
                for (int j = 0; j < fMatrix[i].Length; ++j)
                {
                    Console.Write(fMatrix[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //неявно типизированные переменные для хранения массива и строки

            var varArray = new[] { 1, 2, 3, 4 };
            var varString = "String";

            //кортеж из 5 элементов

            (int, string, char, string, long) tup1 = (152, "worm", 'g', "abra", 59324);

            //Вывод кортежа на консоль

            Console.WriteLine(tup1);
            Console.WriteLine($"{tup1.Item1} {tup1.Item2} {tup1.Item4}");

            //распаковка кортежа в переменные

            {
                (int qrew1, string qrew2, char qrew3, string qrew4, long qrew5) = tup1;
            }

            {
                int qrew1;
                string qrew2;
                char qrew3;
                string qrew4;
                long qrew5;
                (qrew1, qrew2, qrew3, qrew4, qrew5) = tup1;

                //использование переменной ( _ )

                int _ = 10;

                // cравние двух кортежей

                (int, string) tup2 = (76, "ghtyui");
                (int, string) tup3 = (76, "ghtyui");
                Console.WriteLine(tup2 == tup3);
                Console.WriteLine(tup2 != tup3);

                //локальная функция

                static void Retorl(int[] numbers, string str)
                {
                    (int MinA, int MaxA, int Sum, char FirstL) tuple;
                    tuple.MinA = numbers.Min();
                    tuple.MaxA = numbers.Max();
                    int summa = 0;
                    foreach (int item in numbers)
                    {
                        summa += item;
                    }
                    tuple.Sum = summa;
                    tuple.FirstL = str[0];
                    Console.WriteLine($"Максимальый элемент = {tuple.MaxA}, Минимальный элемент = {tuple.MinA}, Сумма = {tuple.Sum}, Первая буква = {tuple.FirstL}");
                }

                int[] MyArr = new int[4] { 1, 2, 3, 4 };
                string myStr = "Nadia";
                Retorl(MyArr, myStr);

                // checked/unchecked

                Console.WriteLine("CHECKED AND UNCHECKED");
                Console.Write($"Checked = { CheckedFun()}, Uncheked = {UnCheckedFun()}\n");
            }
        }
    }

}

