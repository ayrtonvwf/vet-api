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
    public class VetController : ControllerBase
    {
        // GET api/vet
        [HttpGet]
        public ActionResult<IEnumerable<Vet>> Get()
        {
            var service = new VetService();

            var vets = service.GetAll();

            return Ok(vets);
        }

        // GET api/vet/5
        [HttpGet("{id}")]
        public ActionResult<Vet> Get(long id)
        {
            var service = new VetService();

            var vet = service.GetID(id);

            if (vet == null)
            {
                return NotFound();
            }

            return vet;
        }

        // POST api/vet
        [HttpPost]
        public ActionResult<Vet> Post([FromBody] Vet vet)
        {            
            var service = new VetService();
            
            service.Store(vet);

            return vet;
        }

        // PUT api/vet/5
        [HttpPut("{id}")]
        public ActionResult<Vet> Put(long id, [FromBody] Vet vet)
        {
            var service = new VetService();
 
            if (service.GetID(id) == null)
            {
                return NotFound();
            }

            vet.VetID = id;

            service.Store(vet);

            return vet;
        }

        // DELETE api/vet/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var service = new VetService();

            var vet = service.GetID(id); 
            if (vet == null)
            {
                return NotFound();
            }

            service.Delete(vet);

            return Ok();
        }
    }
}