namespace lab4
{
    public class Student: Person
    {
        public int Program { get; set; }
        
        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, PhoneNumber: {PhoneNumber}, Program: {Program}";
        }
    }
}