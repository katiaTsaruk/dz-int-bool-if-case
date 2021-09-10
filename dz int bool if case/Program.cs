using System;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace dz_int_bool_if_case
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Case5(1,3,12));
        }

        #region Integer

        static int Int1(int l)
        {
            return l / 100;
        }

        static int Int3(int n)
        {
            return n / 1024;
        }

        static int Int5(int a, int b)
        {
            return a % b;
        }

        static (int, int) Int7(int n)
        {
            return (n % 10 + n / 10, (n / 10) * (n % 10));
        }

        static int Int9(int n)
        {
            return n / 100;
        }

        static (int, int) Int11(int n)
        {
            int n23 = n % 100;
            return (n / 100 + n % 10 + n23 / 10, (n / 100) * (n % 10) * (n23 / 10));
        }

        static int Int13(int n)
        {
            return (n % 100) * 10 + n / 100;
        }

        static int Int15(int n)
        {
            int n23 = n % 100;
            return (n / 100) * 10 + n % 10 + (n23 / 10) * 100;
        }

        static int Int17(int n)
        {
            return (n % 1000) / 100;
        }

        static int Int19(int n)
        {
            return n / 60;
        }

        static int Int21(int n)
        {
            return n % 60;
        }

        static int Int23(int n)
        {
            return (n % 3600) / 60;
        }

        static int Int25(int n)
        {
            return (n + 3) % 7;
        }

        static int Int27(int n)
        {
            int res = (n + 5) % 7;
            if (res == 0)
                res = 7;
            return res;
        }

        static (int, int) Int29(int a, int b, int c)
        {
            return ((a / c) * (b / c), a * b - (a / c) * (b / c));
        }

        #endregion

        #region Boolean

        static bool Bool1(int a)
        {
            return a > 0;
        }

        static bool Bool3(int a)
        {
            return a % 2 == 1;
        }

        static bool Bool5(int a, int b)
        {
            return a >= 0 || b < -2;
        }

        static bool Bool7(int a, int b, int c)
        {
            return a < b && c > b;
        }

        static bool Bool9(int a, int b)
        {
            return a % 2 == 1 || b % 2 == 1;
        }

        static bool Bool11(int a, int b)
        {
            return (a + b) % 2 == 0;
        }

        static bool Bool13(int a, int b, int c)
        {
            return a > 0 || b > 0 || c > 0;
        }

        static bool Bool15(int a, int b, int c)
        {
            if (a * b * c > 0)
                return false;
            return a > 0 || b > 0 || c > 0;
        }

        static bool Bool17(int n)
        {
            return n % 2 == 1 && n / 1000 == 0 && n / 10 != 0 && n / 100 != 0;
        }

        static bool Bool19(int a, int b, int c)
        {
            return a == -b || b == -c || a == -c;
        }

        static bool Bool21(int n)
        {
            return n / 100 < (n % 100) / 10 && (n % 100) / 10 < n % 10;
        }

        static bool Bool23(int n)
        {
            return n / 100 == n % 10;
        }

        static bool Bool25(int x, int y)
        {
            return x < 0 && y > 0;
        }

        static bool Bool27(int x, int y)
        {
            return x < 0;
        }

        static bool Bool29(int x, int y, int x1, int y1, int x2, int y2)
        {
            return x > x1 && x < x2 && y > y1 && y < y2;
        }

        static bool Bool31(int a, int b, int c)
        {
            return a == b || b == c || a == c;
        }

        static bool Bool33(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static bool Bool35(int x1, int y1, int x2, int y2)
        {
            return (x1 * y1) % 2 == (x2 * y2) % 2;
        }

        static bool Bool37(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 1;
        }

        static bool Bool39(int x1, int y1, int x2, int y2)
        {
            return x1 == x2 || y1 == y2 || x1 + y2 == x2 + y1;
        }

        #endregion

        #region If

        static int If1(int n)
        {
            return n > 0 ? n + 1 : n;
        }

        static int If3(int n)
        {
            if (n > 0)
            {
                return n + 1;
            }
            else if (n < 0)
            {
                return n - 2;
            }
            else return 10;
        }

        static (int, int) If5(int a, int b, int c)
        {
            int minus = 0;
            int plus = 0;
            if (a > 0)
                plus++;
            if (a < 0)
                minus++;
            if (b > 0)
                plus++;
            if (b < 0)
                minus++;
            if (c > 0)
                plus++;
            if (c < 0)
                minus++;
            return (plus, minus);
        }
        static int If7(int a, int b)
        {
            if (a != b)
                return a < b ? 1 : 2;
            else return 12;
        }

        static (int,int) If9(int a, int b)
        {
            (a, b) = b > a ? (a, b) : (b, a);
            return (a, b) ;
        }

        static (int, int) If11(int a, int b)
        {
            if (a == b)
            {
                (a, b) = (0, 0);
            }
            else (a, b) = a > b ? (a, a) : (b, b);

            return (a, b);
        }
        static int If13(int a,int b,int c)
        {
            if (a > b && b > c)
                return b;
            else if (b > c && c > a)
                return c;
            else return a;
        }

        static int If15(int a, int b, int c)
        {
            if (c < a && c < b)
                return a + b;
            else if (a < b && a < c)
                return b + c;
            else return a + c;
        }

        static (int, int, int) If17(int a, int b, int c)
        {
            if (a > b && b > c)
                (a, b, c) = (2 * a, 2 * b, 2 * c);
            else if (a < b && b < c)
                (a, b, c) = (2 * a, 2 * b, 2 * c);
            else (a, b, c) = (-a, -b, -c);
            return (a, b, c);
        }

        static int If19(int a, int b, int c, int d)
        {
            if (a == b && b == c)
                return 4;
            else if (a == b && b == d)
                return 3;
            else if (a == c && c == d)
                return 2;
            else return 1;
        }

        static int If21(int x, int y)
        {
            if (x == 0 && y == 0)
                return 0;
            else if (x == 0)
                return 2;
            else if (y == 0)
                return 1;
            else return 3;
        }

        static (int, int) If23(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            int x4, y4;
            if (x1 == x2)
                x4 = x3;
            else if (x1 == x3)
                x4 = x2;
            else x4 = x1;
            
            if (y1 == y2)
                y4 = y3;
            else if (y1 == y3)
                y4 = y2;
            else y4 = y1;
            
            return (x4, y4);
        }

        static int If25(int x)
        {
            return x > 2 || x < -2 ? 2 * x : -3 * x;
        }

        static double If27(double x)
        {
            if (x < 0)
                return 0;
            else return Math.Floor(x) % 2 == 0 ? 1 : -1;
        }

        static void If29(int x)
        {
            if (x < 0)
                Console.Write("отрицаиельное ");
            else if (x > 0)
                Console.Write("положительное ");
            else Console.Write("нулевое ");
            if (x % 2 == 0)
                Console.Write("четное ");
            else Console.Write("нечетное ");
            Console.Write("число");
        }
        #endregion

        #region Case
        static string Case1(int n)
        {
            switch (n)
            {
                case 1:
                    return "monday";
                case 2:
                    return "tuesday";
                case 3:
                    return "wednesday";
                case 4:
                    return "thursday";
                case 5:
                    return "friday";
                case 6:
                    return "saturday";
                case 7:
                    return "sunday";
            }
            return null;
        }
        
        static string Case3(int n)
        {
            switch (n)
            {
                case 1: 
                case 2:
                case 12:
                    return "winter";
                case 3:
                case 4:
                case 5:
                    return "spring";
                case 6:
                case 7:
                case 8:
                    return "summer";
                case 9:
                case 10:
                case 11:
                    return "autumn";
            }
            return null;
        }

        static int Case5(int n, int a, int b)
        {
            switch (n)
            {
                case 1:
                    return a + b;
                case 2:
                    return a - b;
                case 3:
                    return a * b;
                case 4:
                    return a / b;
            }
            return 0;
        }

        static double Case7(int n, int a)
        {
            switch (a)
            {
                case 1:
                    return n;
                case 2:
                    return n * 1000000;
                case 3:
                    return n * 1000;
                case 4:
                    return n / 1000;
                case 5:
                    return n / 100;
            }
            return 0;
        }

        static (int, int) Case9(int m, int d)
        {
            switch (d)
            {
                case 31:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            return (1, m + 1);
                        case 12:
                            return (1,1);
                    } 
                    break;
                case 30:
                    switch (m)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            return (1, m + 1);
                    } 
                    break;
                case 28:
                    switch (m)
                    {
                        case 2:
                            return (1, m + 1);
                    } 
                    break;
            }

            return (d + 1, m + 1);
        }

        static string Case11(string c, int n1, int n2)
        {
            int side = 0;
            switch(c)
            {
                case "n":
                    side = 1;
                    break;
                case "w":
                    side = 2;
                    break;
                case "s":
                    side = 3;
                    break;
                case "e":
                    side = 0;
                    break;
            }
            switch (n1)
            {
                case 1:
                    side++;
                    break;
                case 2:
                    side += 2;
                    break;
                case -1:
                    side--;
                    break;
            }
            switch (n2)
            {
                case 1:
                    side++;
                    break;
                case 2:
                    side += 2;
                    break;
                case -1:
                    side--;
                    break;
            }

            switch (side % 4)
            {
                case 0:
                    c = "e";
                    break;
                case 1:
                    c = "n";
                    break;
                case 2:
                    c = "w";
                    break;
                case 3:
                    c = "s";
                    break;
            }

            return c;
        }

        static (double, double, double) Case13(int n, int x)
        {
            switch (n)
            {
                case 1:
                    return (x * Math.Sqrt(2), x * Math.Sqrt(2) / 2, x * x / 2);
                case 2:
                    return (x / Math.Sqrt(2), x / 2, x * x / 4);
                case 3:
                    return ( x * Math.Sqrt(2), 2 * x, x * x);
                case 4:
                    return (Math.Sqrt(x) * Math.Sqrt(2), Math.Sqrt(4 * x), Math.Sqrt(x));
            }

            return (0, 0, 0);
        }

        static void Case15(int n, int m)
        {
            switch (n)
            {
                case 6:
                    Console.Write("шесть ");
                    break;
                case 7:
                    Console.Write("семь ");
                    break;
                case 8:
                    Console.Write("восемь");
                    break;
                case 9:
                    Console.Write("девять ");
                    break;
                case 10:
                    Console.Write("десять ");
                    break;
                case 11:
                    Console.Write("валет ");
                    break;
                case 12:
                    Console.Write("дама ");
                    break;
                case 13:
                    Console.Write("король ");
                    break;
                case 14:
                    Console.Write("туз ");
                    break;
            }

            switch (m)
            {
                case 1:
                    Console.Write("пик");
                    break;
                case 2:
                    Console.Write("треф");
                    break;
                case 3:
                    Console.Write("бубен");
                    break;
                case 4:
                    Console.Write("червей");
                    break;
            }
        }

        static void Case17(int n)
        {
            switch (n / 10)
            {
                case 1:
                    switch (n % 10)
                    {
                        case 1:
                            Console.Write( "одинадцать");
                            break;
                        case 2:
                            Console.Write( "двенадцать");
                            break;
                        case 3:
                            Console.Write( "тринадцать");
                            break;
                        case 4:
                            Console.Write( "четырнадцать");
                            break;
                        case 5:
                            Console.Write( "пятнадцать");
                            break;
                        case 6:
                            Console.Write( "шестнадцать");
                            break;
                        case 7:
                            Console.Write( "семнадцать");
                            break;
                        case 8:
                            Console.Write( "восемнадцать");
                            break;
                        case 9:
                            Console.Write( "девятнадцать");
                            break;
                        case 0:
                            Console.Write( "десять");
                            break;
                    }

                    break;
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
            }

            switch (n / 10)
            {
                case 2:
                case 3:
                    switch (n % 10)
                    {
                        case 1:
                            Console.Write( "одно");
                            break;
                        case 2:
                            Console.Write( "два");
                            break;
                        case 3:
                            Console.Write( "три");
                            break;
                        case 4:
                            Console.Write( "четыре");
                            break;
                        case 5:
                            Console.Write( "пять");
                            break;
                        case 6:
                            Console.Write( "шесть");
                            break;
                        case 7:
                            Console.Write( "семь");
                            break;
                        case 8:
                            Console.Write( "восемь");
                            break;
                        case 9:
                            Console.Write( "девять");
                            break;
                    }

                    break;
            }

            switch (n % 10)
            {
                case 1:
                    Console.Write(" учебное задание");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.Write(" учебных задания");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    Console.Write(" учебных заданий");
                    break;
            }
        }
        
        static void Case19(int n)
        {
            switch ((n / 12) % 5)
            {
                case 0:
                    Console.Write("зеленый ");
                    break;
                case 1:
                    Console.Write("красный ");
                    break;
                case 2:
                    Console.Write("желтый ");
                    break;
                case 3:
                    Console.Write("белый ");
                    break;
                case 4:
                    Console.Write("черный ");
                    break;
            }

            switch (n % 12)
            {
                case 1:
                    Console.Write("крыса");
                    break;
                case 2:
                    Console.Write("корова");
                    break;
                case 3:
                    Console.Write("тигр");
                    break;
                case 4:
                    Console.Write("заяц");
                    break;
                case 5:
                    Console.Write("дракон");
                    break;
                case 0:
                    Console.Write("свинья");
                    break;
                case 6:
                    Console.Write("змея");
                    break;
                case 7:
                    Console.Write("лошадь");
                    break;
                case 8:
                    Console.Write("овца");
                    break;
                case 9:
                    Console.Write("обезьяна");
                    break;
                case 10:
                    Console.Write("курица");
                    break;
                case 11:
                    Console.Write("собака");
                    break;
            }
        }
        #endregion
    }
}