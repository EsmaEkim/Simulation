using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulationsprojekte.Abstrack
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Alle Informationen über" + customer.FirstName + customer.LastName + " wurden erfolgreich aus der Datenbank gelöscht");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + customer.LastName + " wurde erfolgreich in der Datenbank gespeichert");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Die Informationen über" + customer.FirstName + customer.LastName + " wurden in der Datenbank aktualisiert");
        }
    }
}
