namespace ConsoleApp1
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }
        public Gender Gender { get; set; }

        public User() { }
        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. " +
                $"{(Age > 10 ? $"I am {Age} years old." : "I am a baby.")} I am {Gender}.";
        }
    }

    public enum Gender
    {
        Female,
        Male,
        NotMentioned
    }
}
