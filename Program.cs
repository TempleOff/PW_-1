using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW__1
{
    static class lib1
    {
        public static void stpow(string a,int b)
        {
            string str = "";
            for (int i = 0; i < b; i++)
            {
                str += a;
            }
            Console.WriteLine(str);
        }
        public static void rev1(string a)
        {
            var total = "";
            for (int i = a.Length-1; i >= 0; i--)
            {
                total += a[i];
            }
            Console.WriteLine(total);
        }
        public static void rev2(string a)
        {
            var total = "";
            for (int i = a.Length-1; i >= 0; i--)
            {
                total += a[i];
            }
            Console.WriteLine(total);
        }
        public static void rem(string str,string s)
        {
            char[] a = str.ToCharArray();
            string total = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(Convert.ToChar(s)))
                {
                    
                }
                else
                {
                    total += a[i];
                }
            }
            Console.WriteLine(total);
        }
        public static void len(string str)
        {
            var a = str.Length.ToString();
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 2
            Console.WriteLine("№2");
            string a1;
            int b1;
            a1 = Console.ReadLine();
            b1 = Convert.ToInt32(Console.ReadLine());
            lib1.stpow(a1, b1);

            // 3
            Console.WriteLine("№3");
            string a2;
            a2 = Console.ReadLine();
            lib1.rev1(a2);

            // 4
            Console.WriteLine("№4");
            string a3;
            a3 = Console.ReadLine();
            lib1.rev1(a3);

            // 5
            Console.WriteLine("№5");
            string a4;
            string b4;
            a4 = Console.ReadLine();
            b4 = Console.ReadLine();
            lib1.rem(a4, b4);

            // 6 
            Console.WriteLine("№6");
            string a5;
            a5 = Console.ReadLine();
            lib1.len(a5);

            Console.WriteLine("нажмите ENTER для выхода из консоли");
            Console.ReadLine();

        }
    }
}
