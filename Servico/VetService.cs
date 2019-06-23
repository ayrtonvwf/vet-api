using System.Collections.Generic;
using Model;
using Persistencia;

namespace Servico
{
    public class VetService
    {
        private	VetDAL _dal = new VetDAL();

        public IEnumerable<Vet> GetAll()
        {
            return _dal.GetAll();
        }

        public Vet GetID(long id)
        {
            return _dal.GetID(id);
        }

        public void Store(Vet vet)
        {
            _dal.Store(vet);
        }

        public void Delete(Vet vet)
        {
            _dal.Delete(vet);
        }
    }
}