namespace Traning_Fyra_OPP
{
    public class Student : Person
    {
        public int Id;
        public string Major;

        public void Study()
        {
            Console.WriteLine($"Hello my name is {Name}.My major is {Major}. I am {Age} years old and my student ID is {Id}.");
            // Accessing inherited public field Name
        }

    }
}
