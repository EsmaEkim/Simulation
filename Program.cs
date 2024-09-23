using Simulationsprojekte.Abstrack;
using Simulationsprojekte.Concrete;
using System;

namespace Simulationsprojekte
{
    public class Program
    {
        static void Main(string[] args)
        {
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2001, 11, 26), FirstName = "Esma", LastName = "Ekim", NationalityId = "12345678910" });
            Console.ReadLine();
          

        }
    }
}
