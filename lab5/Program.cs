using System;

namespace lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher
            {
                IdentityNumber = "A001",
                FullName = "Nguyen Hoang Tuan",
                BaseSalary = 100,
                SkillLever =  1,
                SeniorLecture = 60000,
                Bonus = 1000,
                HighSchoolTeacherCode = "TEACHER001"
            };
            var universityTeacher = new UniversityTeacher
            {
                IdentityNumber = "A002",
                FullName = "Le Dat",
                BaseSalary = 100,
                SkillLever =  1,
                SeniorLecture = 30000,
                Bonus = 9000,
                UniversityTeacherCode = "UNIVERSITY_TEACHER002",
                EnglishSkillLever = 2
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}