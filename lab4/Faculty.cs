using System;

namespace lab4
{
    public class Faculty : Employee
    {
        public string OfficeHour { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            return
                $"Name: {Name}, Email: {Email}, PhoneNumber: {PhoneNumber}, Department: {Department}, Salary: {Salary}, DateHired: {DateHired}, OfficeHour: {OfficeHour}, Rank: {Rank}";
        }

        public override double CalculBonus()
        {
            return 1000 + 0.05 * Salary;
        }

        public override void CalculatedVacation()
        {
            Console.WriteLine("Vui lòng nhập số năm cống hiến: ");
            var year = int.Parse(Console.ReadLine());
            if (year >= 3 && Rank == 1)
            {
                Console.WriteLine("Được 6 tuần nghỉ");
            }
            else if (year > 3)
            {
                Console.WriteLine("Được 5 tuần nghỉ");
            }
            else
            {
                Console.WriteLine("Được 4 tuần nghỉ");
            }
        }
    }
}