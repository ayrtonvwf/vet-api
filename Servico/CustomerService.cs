using System.Collections.Generic;
using Model;
using Persistencia;

namespace Servico
{
    public class CustomerService
    {
        private	CustomerDAL _dal = new CustomerDAL();

        public IEnumerable<Customer> GetAll()
        {
            return _dal.GetAll();
        }

        public Customer GetID(long id)
        {
            return _dal.GetID(id);
        }

        public void Store(Customer customer)
        {
            _dal.Store(customer);
        }

        public void Delete(Customer customer)
        {
            _dal.Delete(customer);
        }
    }
}