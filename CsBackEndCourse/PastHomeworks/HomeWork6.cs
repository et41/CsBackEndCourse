using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork6
    {
        public interface ICustomerDataAccess
        {
            string GetCustomerName(int id);
        }
        public class CustomerDataAccess : ICustomerDataAccess
        {
            public CustomerDataAccess()
            {
            }
            public string GetCustomerName(int id)
            {
                return "Dummy Customer Name";
            }
        }
        public class DataAccessFactory
        {
            public static ICustomerDataAccess GetCustomerDataAccessObj()
            {
                return new CustomerDataAccess();
            }
        }
        public class CustomerBusinessLogic
        {
            ICustomerDataAccess _custDataAccess;
            public CustomerBusinessLogic()
            {
                _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
            }
            public string GetCustomerName(int id)
            {
                return _custDataAccess.GetCustomerName(id);
            }

        }
    }
}
