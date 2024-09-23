using Simulationsprojekte.Abstrack;
using Simulationsprojekte.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulationsprojekte.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        private MernisServiceReference1 mernisServiceReference1;

        public StarbucksCustomerManager(MernisServiceReference1 mernisServiceReference1)
        {
            this.mernisServiceReference1 = mernisServiceReference1;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Diese Informationen gehören nicht zu einem gültigen Kunden.");
            }
            

        }

         
    }
}
