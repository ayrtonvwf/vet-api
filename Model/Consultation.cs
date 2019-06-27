using System;
using System.Collections.Generic;

namespace Model
{
    public class Consultation
    {
        public long? ConsultationID { get; set; }

        public DateTime Date { get; set; }

        public DateTime PaymentExpiration { get; set; }
        
        public string Description { get; set; }

        public double Value { get; set; }

        public DateTime? PaidAt { get; set; }

        public long AnimalID { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual IEnumerable<Prescription> Prescriptions { get; set; }

        public long VetID { get; set; }

        public virtual Vet Vet { get; set; }
    }
}