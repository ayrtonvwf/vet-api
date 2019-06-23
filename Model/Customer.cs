using System.Collections.Generic;

namespace Model
{
    public class Customer
    {
        public long? CustomerID { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Animal> Animals { get; set; }
    }
}