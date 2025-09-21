namespace Traning_Fyra_OPP
{
    public class Student : Person
    {
        public int Id;
        public string Major;

        public void Study()
        {
            Console.WriteLine($"My major is {Major},and my student ID is {Id}.");
            // Accessing inherited public field Name
        }

    }
}
