using System.Collections.Generic;
using System.Linq;
using Model;

namespace Persistencia
{
    public class CustomerDAL
    {
        public IEnumerable<Customer> GetAll()
        {
            using (var context = new EFContext())
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Customers.Find(id);
            }
        }

        public void Store(Customer customer)
        {
            using (var context = new EFContext())
            {
                if (customer.CustomerID == null)
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                }

                context.SaveChanges();
            }
        }

        public void Delete(Customer customer)
        {
            using (var context = new EFContext())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
    }
}