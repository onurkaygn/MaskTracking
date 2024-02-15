using Business.Concrete;
using Entities.Concrete;

namespace engindemirogcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "ONURALP";
            person1.LastName = "KAYGIN";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 34723851250;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }
    }
}