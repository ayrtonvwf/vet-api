using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Persistencia
{
    public class VetDAL
    {
        public IEnumerable<Vet> GetAll()
        {
            using (var context = new EFContext())
            {
                return context.Vets.ToList();
            }
        }

        public Vet GetID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Vets.Find(id);
            }
        }

        public void Store(Vet vet)
        {
            using (var context = new EFContext())
            {
                if (vet.VetID == null)
                {
                    context.Vets.Add(vet);
                }
                else
                {
                    context.Vets.Update(vet);
                }

                context.SaveChanges();
            }
        }

        public void Delete(Vet vet)
        {
            using (var context = new EFContext())
            {
                context.Vets.Remove(vet);
                context.SaveChanges();
            }
        }
    }
}