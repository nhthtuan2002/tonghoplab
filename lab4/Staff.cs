using System;

namespace lab4
{
    public class Staff : Employee
    {
        public string Title { get; set; }

        public override string ToString()
        {
            return
                $"Name: {Name}, Email: {Email}, PhoneNumber: {PhoneNumber}, Department: {Department}, Salary: {Salary}, DateHired: {DateHired}, Title: {Title}";
        }

        public override double CalculBonus()
        {
            return 0.06 * Salary;
        }

        public override void CalculatedVacation()
        {
            Console.WriteLine("Vui lòng nhập số năm");
            var year = int.Parse(Console.ReadLine());
            if (year >= 5)
            {
                Console.WriteLine("Được 4 tuần");
            }
            else
            {
                Console.WriteLine("Được 3 tuần");
            }
        }
    }
}