using Api.Data;
using Api.Models;

namespace Api.GenericRepository
{
    public class CreditCardRepository : GenericRepository<CreditCard>, ICreditCardRepository
    {
        public CreditCardRepository(InheritanceMappingContext context) : base(context)
        {

        }
        //implement credit card specific methods. Like get one instance of card holder.
    }
}
