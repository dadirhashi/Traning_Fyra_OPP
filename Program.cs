namespace Traning_Fyra_OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            Student student = new Student();

            student.Major = "Math";
            student.Age = 30;
            student.Name = "Alice";
            student.Id = 1234567;

            student.Introduce();
            student.Study();

            // The following line would cause a compilation error because SocialSecurityNumber is private
            // person.SocialSecurityNumber = 123456789;

            

        }
  
    }
}
