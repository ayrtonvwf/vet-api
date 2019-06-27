using System.Collections.Generic;

namespace Model
{
    public class Animal
    {
        public long? AnimalID { get; set; }
        
        public string Breed { get; set; }
        
        public string Name { get; set; }
        
        public long CustomerID { get; set; }
        
        public virtual Customer Customer { get; set; }
        
        public virtual IEnumerable<Consultation> Consultations { get; set; }
    }
}