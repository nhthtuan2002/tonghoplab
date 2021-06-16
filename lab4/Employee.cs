namespace lab4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public string DateHired { get; set; }

        public override string ToString()
        {
            return
                $"Name: {Name}, Email: {Email}, PhoneNumber: {PhoneNumber}, Department: {Department}, Salary: {Salary}, DateHired: {DateHired}";
        }

        public abstract double CalculBonus();
        public abstract void CalculatedVacation();
    }
}