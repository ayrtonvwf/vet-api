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
    public class AnimalController : ControllerBase
    {
        // GET api/animal
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            var service = new AnimalService();

            var animals = service.GetAll();

            return Ok(animals);
        }

        // GET api/animal/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(long id)
        {
            var service = new AnimalService();

            var animal = service.GetID(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }

        // POST api/animal
        [HttpPost]
        public ActionResult<Animal> Post([FromBody] Animal animal)
        {            
            var service = new AnimalService();
            
            service.Store(animal);

            return animal;
        }

        // PUT api/animal/5
        [HttpPut("{id}")]
        public ActionResult<Animal> Put(long id, [FromBody] Animal animal)
        {
            var service = new AnimalService();
 
            if (service.GetID(id) == null)
            {
                return NotFound();
            }

            animal.AnimalID = id;

            service.Store(animal);

            return animal;
        }

        // DELETE api/animal/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var service = new AnimalService();

            var animal = service.GetID(id); 
            if (animal == null)
            {
                return NotFound();
            }

            service.Delete(animal);

            return Ok();
        }
    }
}