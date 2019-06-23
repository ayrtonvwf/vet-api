using System.Collections.Generic;
using System.Linq;
using Model;

namespace Persistencia
{
    public class ConsultationDAL
    {
        public IEnumerable<Consultation> GetAll()
        {
            using (var context = new EFContext())
            {
                return context.Consultations.ToList();
            }
        }

        public Consultation GetID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Consultations.Find(id);
            }
        }

        public void Store(Consultation consultation)
        {
            using (var context = new EFContext())
            {
                if (consultation.ConsultationID == null)
                {
                    context.Consultations.Add(consultation);
                }
                else
                {
                    context.Consultations.Update(consultation);
                }

                context.SaveChanges();
            }
        }

        public void Delete(Consultation consultation)
        {
            using (var context = new EFContext())
            {
                context.Consultations.Remove(consultation);
                context.SaveChanges();
            }
        }
    }
}