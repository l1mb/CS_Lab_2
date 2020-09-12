using System;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace _2_Lab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random();
            int max_int_value = 2147483647;
            //First_task_a();
            //First_task_e();
            //Second_task_a();
            //Second_task_b();
            //Second_task_c();
            //Second_task_d();
            //Third_task_a();
            //Third_task_b();
            //Third_task_c();
            //Fourth_task();
            //q 5 TASK
            //int[] arr = new int[10];
            //for (short i = 0; i < 10; i++)
            //    arr[i] = random.Next(0, 100);
            //aga(arr, "aga");
            //q 5 TASK

            //q 6 TASK
            Unchecked(max_int_value);
            Checked(max_int_value);
            //q 6 TASK
        }

        public static void Unchecked(int max_value)
        {
            try
            {
                int overflow = unchecked(max_value + 10);
            }
            catch (System.OverflowException e)
            {
                Console.Write($"\nCatched exception: {e}\n");
                return;
            }
            Console.Write("\nThere's no exception\n");
            return;
        }

        public static void Checked(int max_value)
        {
            try
            {
                int overflow = checked(max_value + 10);
            }
            catch (System.OverflowException e)
            {
                Console.Write($"\nCatched exception {e}\n");
                return;
            }
            Console.Write("\nThere's no exception\n");
            return;
        }

        private static Tuple<int, int, int, char> aga(int[] arr, string str)
        {
            int max = 0, min = arr[0], sum = 0;
            char letter = str[0];
            Console.WriteLine("Array:");
            foreach (int el in arr)
            {
                sum += el;
                if (el > max)
                    max = el;
                else if (el < min)
                    min = el;
                Console.Write($"{el} ");
            }
            Console.Write($"\nString: {str}\nmax: {max}\nmin: {min}\nsum: {sum}\nletter: {letter}");
            return Tuple.Create(max, min, sum, letter);
        }

        public static void First_task_a()
        {
            bool True = false; //q 1 byte
            byte max_bytes = 255; //q 1 byte
            sbyte min_sbyte = -127; //q 1 byte signed
            char symbol = 'a'; //q 2 byte
            decimal dec = 12345678901234567890; //q 16 byte
            double x2 = 8; //q 8 byte
            float x1 = 4; //q 4 byte
            int Int = 4; //q 4 byte
            uint UInt = 1; //q 4 byte unsigned
            long Long = 8; //q 8 byte
            ulong ULong = 8; //q 8 byte unsigned
            short Short = 2; //q 2 byte
            ushort UShort = 2; //q 2 byte unsigned
            Console.Write($"bool:\t{True}\nbyte:\t{max_bytes}\nsbyte:\t{min_sbyte}\nchar:\t{symbol}\ndecimal:\t{dec}\n");
            Console.Write($"double:\t{x2}\nfloat:\t{x1}\nint:\t{Int}\nuint:\t{UInt}\n");
            Console.Write($"long:\t{Long}\nulong:\t{ULong}\nshort:\t{Short}\nushort:\t{UShort}\n");
        }

        public static void First_task_b()
        {
            uint UInt = 8;
            byte a = 1;

            //! Явное преобразование
            bool True = Convert.ToBoolean(UInt); //q uint -> bool
            uint UINT = Convert.ToUInt32(UInt); //q uint -> uint32
            double x2 = Convert.ToDouble(UInt); //q uint -> double
            sbyte signed_byte = Convert.ToSByte(UInt); //q uint -> sbyte
            char symbol = Convert.ToChar(UInt); //q uint -> char
                                                //! Явное преобразование

            //! Неявное преобразование
            int aga = a; //q byte -> int
            float AGA = aga; //q int -> float
            double ogo = AGA; //q float -> double
            long wow = aga; //q int -> long
            double WOW = wow; //q long -> double
                              //! Неявное преобразование
        }

        public static void First_task_c()
        {
            int a = 1;
            float aa = 11;
            double aaa = 111;
            //q упаковал
            object A = a, AA = aa, AAA = aaa;
            //q упаковал
            //! распаковал
            a = (int)A;
            aa = (float)AA;
            aaa = (double)AAA;
            //! распаковал
        }

        public static void First_task_d()
        {
            var variable = 123;
            int aga = Convert.ToInt32(variable); //q var -> int (явно)
            int AGA = variable; //q var -> int (неявно)
            Console.Write($"var:\t{variable}");
        }

        public static void First_task_e()
        {
            //! int NULL = null <- ТАК НИЗЯ, НЕ РАБОТАЕТ
            int? NULL = null; //q простая форма записи
            Nullable<int> NULL2 = null; //q нормальная форма записи
            if (NULL2.HasValue)
                Console.Write($"Значение NULL2:\t{NULL2}");
            else
            {
                Console.Write("NULL2:\tnull\n");
                NULL2 = 2;
                Console.Write($"Присвоено значение:\t{NULL2.Value}\n");
            }
        }

        public static void First_task_f()
        {
            var aga = "wow";
            //aga = 5;
        }

        public static void Second_task_a()
        {
            string str1 = "abc", str2 = "bcd";
            Console.Write($"'abc' compare 'bcd':\t{String.Compare(str1, str2)}");
        }

        public static void Second_task_b()
        {
            String str1 = "aga", str2 = "AGA, imenno tak, da", str3 = "ogo";
            Console.Write("aga + AGA:\t{0}\n", String.Concat(str1, str2)); //! CONCATINATION
            str3 = String.Copy(str1); //! COPY
            Console.Write($"Substring from 1 to 2 'aga' :\t{str1.Substring(0, 2)}\n"); //! SUBSTRING
            string[] from_split = str2.Split(); //! SPLIT
                                                //q Split output
            foreach (var i in from_split)
            {
                Console.Write($"{i}\n");
            }
            //q Split output
            str1 = str1.Insert(3, ", str"); //! INSERT
            Console.WriteLine(str1);
            str1 = str1.Remove(3); //! REMOVE
            Console.WriteLine(str1);
        }

        public static void Second_task_c()
        {
            string NULL = null, empty = "";
            if (String.IsNullOrEmpty(NULL) && String.IsNullOrEmpty(empty))
                Console.Write("NULL and empty is NullOrEmpty\n");
            else
                Console.Write("Something is not NullOrEmpty\n");
            Console.Write($"null and empty compare:\t{String.Compare(NULL, empty)}");
        }

        public static void Second_task_d()
        {
            StringBuilder str = new StringBuilder("aga, imenno tak");
            Console.Write($"REMOVE:\t{str.Remove(3, 2)}\n"); //! REMOVE
            Console.Write($"APPENDFORMAT:\t{str.AppendFormat(", da")}\n"); //! INSERT IN THE END
            Console.Write($"INSERT:\t{str.Insert(0, "ogo, ")}"); //! INSERT IN BEGIN
        }

        public static void Third_task_a()
        {
            var random = new Random();

            int[,] arr = new int[10, 10];
            for (short i = 0; i < 10; i++)
            {
                for (short j = 0; j < 10; j++)
                {
                    arr[i, j] = random.Next(0, 10);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write('\n');
            }
        }

        public static void Third_task_b()
        {
            string[] arr = { "Lord", "Commander", "of", "nothing" };
            foreach (string str in arr)
                Console.WriteLine($"{str}");
            Console.Write($"arr size:\t{arr.Length}\nВведите позицию замены: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Введите замену: ");
            string temp = Console.ReadLine();
            arr[position] = temp;
            foreach (string str in arr)
                Console.WriteLine($"{str}");
        }

        public static void Third_task_c()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[2];
            arr[1] = new int[3];
            arr[2] = new int[4];

            Console.Write("Вводи числа" + "\n");
            for (int i = 0; i < arr.Length; i++)
                for (int z = 0; z < arr[i].Length; z++)
                    arr[i][z] = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int z = 0; z < arr[i].Length; z++)
                {
                    Console.Write($"{arr[i][z]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Third_task_d()
        {
            var arr1 = new[] { 1, 2, 3 };
            var arr2 = new[] { "aga", "AGA" };
        }

        public static void Fourth_task()
        {
            (int Int, string Str1, char Symbol, string Str2, ulong ULong) tuple = (1, "aga", 'q', "AGA", 2);
            Console.Write($"Весь кортеж:\t{tuple}\n1 элемент:\t{tuple.Item1}\n3 элемент:\t{tuple.Item3}\n4 элемент:\t{tuple.Item4}");
            //q 1-й вариант
            var tuple1 = ("aga", 1);
            (string Str1, int Int) = tuple1;
            //q 1-й вариант

            //q 2-й вариант
            var tuple2 = ("aga", 1);
            var (str, INT) = tuple2;
            //q 2-й вариант

            //q 3-й вариант
            var aga = string.Empty;
            var ne_aga = 0;
            var tuple3 = ("aga", 2);
            (aga, ne_aga) = tuple3;
            //q 3-й вариант

            Console.Write($"\ntuple2 compareto tuple3:\t{tuple2.CompareTo(tuple3)}");
        }
        //gg
    }
}