using System.Collections.Generic;

namespace Model
{
    public class Vet
    {
        public long? VetID { get; set; }
        
        public string Name { get; set; }
        
        public virtual IEnumerable<Consultation> Consultations { get; set; }
    }
}