using System;
using System.Security.Cryptography;

namespace dz_int_bool_if_case
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Bool31(1, 1, 2));
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

        static (int,int) Int7(int n)
        {
           return (n%10+n/10,(n/10)*(n%10));
        }

        static int Int9(int n)
        {
            return n / 100;
        }

        static (int,int) Int11(int n)
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
            return (n % 3600)/60;
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

        static bool Bool5(int a, int b )
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

        static bool Bool15(int a,int b, int c)
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
            return a == -b || b== -c || a == -c;
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
    }
}
















