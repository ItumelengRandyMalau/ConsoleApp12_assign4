namespace ConsoleApp12_assign4
{
    internal class Program
    {
        class Person
            //creating class fields
        {
            public string firstName;
            public string lastName;
            private int age;
            public string gender;

            //creating constructor to initialize the fields
            public Person(string FirstName, string LastName, int Age, string Gender)
            {
                this.firstName = FirstName;
                this.lastName = LastName;
                this.age = Age;
                this.gender = Gender;
            }
            public void introduce()
            {
                Console.WriteLine("Introducing...");
                Console.WriteLine($"My name is {firstName}, {lastName}.");
                Console.WriteLine($"I am {age} years old and the gender is {gender}.");
            }
        }
        static void Main(string[] args)
        {
            var person = new Person("Itumeleng Randy", "Malau", 26, "Female");
            person.introduce();
        }
    }
}
