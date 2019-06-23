using System.Collections.Generic;
using System.Linq;
using Model;

namespace Persistencia
{
    public class PrescriptionDAL
    {
        public IEnumerable<Prescription> GetAll()
        {
            using (var context = new EFContext())
            {
                return context.Prescriptions.ToList();
            }
        }

        public Prescription GetID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Prescriptions.Find(id);
            }
        }

        public void Store(Prescription prescription)
        {
            using (var context = new EFContext())
            {
                if (prescription.PrescriptionID == null)
                {
                    context.Prescriptions.Add(prescription);
                }
                else
                {
                    context.Prescriptions.Update(prescription);
                }

                context.SaveChanges();
            }
        }

        public void Delete(Prescription prescription)
        {
            using (var context = new EFContext())
            {
                context.Prescriptions.Remove(prescription);
                context.SaveChanges();
            }
        }
    }
}