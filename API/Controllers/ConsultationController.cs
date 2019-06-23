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
    public class ConsultationController : ControllerBase
    {
        // GET api/consultation
        [HttpGet]
        public ActionResult<IEnumerable<Consultation>> Get()
        {
            var service = new ConsultationService();

            var consultations = service.GetAll();

            return Ok(consultations);
        }

        // GET api/consultation/5
        [HttpGet("{id}")]
        public ActionResult<Consultation> Get(long id)
        {
            var service = new ConsultationService();

            var consultation = service.GetID(id);

            if (consultation == null)
            {
                return NotFound();
            }

            return consultation;
        }

        // POST api/consultation
        [HttpPost]
        public ActionResult<Consultation> Post([FromBody] Consultation consultation)
        {            
            var service = new ConsultationService();
            
            service.Store(consultation);

            return consultation;
        }

        // PUT api/consultation/5
        [HttpPut("{id}")]
        public ActionResult<Consultation> Put(long id, [FromBody] Consultation consultation)
        {
            var service = new ConsultationService();
 
            if (service.GetID(id) == null)
            {
                return NotFound();
            }

            consultation.ConsultationID = id;

            service.Store(consultation);

            return consultation;
        }

        // DELETE api/consultation/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var service = new ConsultationService();

            var consultation = service.GetID(id); 
            if (consultation == null)
            {
                return NotFound();
            }

            service.Delete(consultation);

            return Ok();
        }
    }
}