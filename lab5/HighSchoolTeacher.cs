namespace lab5
{
    public class HighSchoolTeacher: Person, IEmployeeAction
    {
        public string HighSchoolTeacherCode { get; set; }

        public double CalculateSalary()
        {
            return BaseSalary * SkillLever + SeniorLecture + Bonus;
        }
    }
}