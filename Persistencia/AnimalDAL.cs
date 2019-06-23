using System.Collections.Generic;
using System.Linq;
using Model;

namespace Persistencia
{
    public class AnimalDAL
    {
        public IEnumerable<Animal> GetAll()
        {
            using (var context = new EFContext())
            {
                return context.Animals.ToList();
            }
        }

        public Animal GetID(long id)
        {
            using (var context = new EFContext())
            {
                return context.Animals.Find(id);
            }
        }

        public void Store(Animal animal)
        {
            using (var context = new EFContext())
            {
                if (animal.AnimalID == null)
                {
                    context.Animals.Add(animal);
                }
                else
                {
                    context.Animals.Update(animal);
                }

                context.SaveChanges();
            }
        }

        public void Delete(Animal animal)
        {
            using (var context = new EFContext())
            {
                context.Animals.Remove(animal);
                context.SaveChanges();
            }
        }
    }
}