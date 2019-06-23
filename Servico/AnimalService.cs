using System.Collections.Generic;
using Model;
using Persistencia;

namespace Servico
{
    public class AnimalService
    {
        private	AnimalDAL _dal = new AnimalDAL();

        public IEnumerable<Animal> GetAll()
        {
            return _dal.GetAll();
        }

        public Animal GetID(long id)
        {
            return _dal.GetID(id);
        }

        public void Store(Animal animal)
        {
            _dal.Store(animal);
        }

        public void Delete(Animal animal)
        {
            _dal.Delete(animal);
        }
    }
}