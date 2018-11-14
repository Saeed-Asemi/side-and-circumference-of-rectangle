using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace side_and_circumference_of_rectangle
{
    class Program
    {
        static void side(int a, int b) //Masahat
        {
            Console.WriteLine($"Side of circle is : {a*b}");
        }
        static void circumference(int a, int b) //Mohit
        {
            Console.WriteLine($"circumference of circle is : { (a+b)*2 }");
        }
        static void Main(string[] args)
        {
            int m = 0;
            int n= 0;
            Console.Write("Please enter length of rectangle : "); 
            m = int.Parse(Console.ReadLine());
            Console.Write("Please enter width of rectangle : ");
            n = int.Parse(Console.ReadLine());
            side(m,n);
            circumference(m,n);
            Console.ReadKey();
        }
    }
}