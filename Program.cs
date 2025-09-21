namespace Traning_Fyra_OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Alice";
            person.Age = 30;
            person.Introduce();
            // The following line would cause a compilation error because SocialSecurityNumber is private
            // person.SocialSecurityNumber = 123456789;

        }


        public class Person
        {
            public string Name;
            public int Age;
            private int SocialSecurityNumber;

            public void Introduce()
            {
                Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
            }




        }
    }
}
