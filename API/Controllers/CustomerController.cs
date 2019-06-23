using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Servico;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET api/customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var service = new CustomerService();

            var customers = service.GetAll();

            return Ok(customers);
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(long id)
        {
            var service = new CustomerService();

            var customer = service.GetID(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // POST api/customer
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {            
            var service = new CustomerService();
            
            service.Store(customer);

            return customer;
        }

        // PUT api/customer/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(long id, [FromBody] Customer customer)
        {
            var service = new CustomerService();

            if (service.GetID(id) == null)
            {
                return NotFound();
            }

            customer.CustomerID = id;

            service.Store(customer);

            return customer;
        }

        // DELETE api/customer/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var service = new CustomerService();

            var customer = service.GetID(id); 
            if (customer == null)
            {
                return NotFound();
            }

            service.Delete(customer);

            return Ok();
        }
    }
}