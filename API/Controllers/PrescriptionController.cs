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
    public class PrescriptionController : ControllerBase
    {
        // GET api/prescription
        [HttpGet]
        public ActionResult<IEnumerable<Prescription>> Get()
        {
            var service = new PrescriptionService();

            var prescriptions = service.GetAll();

            return Ok(prescriptions);
        }

        // GET api/prescription/5
        [HttpGet("{id}")]
        public ActionResult<Prescription> Get(long id)
        {
            var service = new PrescriptionService();

            var prescription = service.GetID(id);

            if (prescription == null)
            {
                return NotFound();
            }

            return prescription;
        }

        // POST api/prescription
        [HttpPost]
        public ActionResult<Prescription> Post([FromBody] Prescription prescription)
        {            
            var service = new PrescriptionService();
            
            service.Store(prescription);

            return prescription;
        }

        // PUT api/prescription/5
        [HttpPut("{id}")]
        public ActionResult<Prescription> Put(long id, [FromBody] Prescription prescription)
        {
            var service = new PrescriptionService();
 
            if (service.GetID(id) == null)
            {
                return NotFound();
            }

            prescription.PrescriptionID = id;

            service.Store(prescription);

            return prescription;
        }

        // DELETE api/prescription/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var service = new PrescriptionService();

            var prescription = service.GetID(id); 
            if (prescription == null)
            {
                return NotFound();
            }

            service.Delete(prescription);

            return Ok();
        }
    }
}