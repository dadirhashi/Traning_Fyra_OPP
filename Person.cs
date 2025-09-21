namespace Traning_Fyra_OPP
{
   
    public class Person
    {
        private int SocialSecurityNumber;
       
        public string Name;
        public int Age;
     
        public void Introduce()
        {
          Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }

    }
}
