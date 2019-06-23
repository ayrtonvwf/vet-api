using System.Collections.Generic;
using Model;
using Persistencia;

namespace Servico
{
    public class PrescriptionService
    {
        private	PrescriptionDAL _dal = new PrescriptionDAL();

        public IEnumerable<Prescription> GetAll()
        {
            return _dal.GetAll();
        }

        public Prescription GetID(long id)
        {
            return _dal.GetID(id);
        }

        public void Store(Prescription prescription)
        {
            _dal.Store(prescription);
        }

        public void Delete(Prescription prescription)
        {
            _dal.Delete(prescription);
        }
    }
}