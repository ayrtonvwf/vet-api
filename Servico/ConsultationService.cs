using System.Collections.Generic;
using Model;
using Persistencia;

namespace Servico
{
    public class ConsultationService
    {
        private	ConsultationDAL _dal = new ConsultationDAL();

        public IEnumerable<Consultation> GetAll()
        {
            return _dal.GetAll();
        }

        public Consultation GetID(long id)
        {
            return _dal.GetID(id);
        }

        public void Store(Consultation consultation)
        {
            _dal.Store(consultation);
        }

        public void Delete(Consultation consultation)
        {
            _dal.Delete(consultation);
        }
    }
}