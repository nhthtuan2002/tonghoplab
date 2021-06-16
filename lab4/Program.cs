using System;
using System.Text;

namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var faculty = new Faculty();
            faculty.CalculatedVacation();
        }
    }
}