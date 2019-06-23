namespace Model
{
    public class Prescription
    {
        public long? PrescriptionID { get; set; }
        
        public string Description { get; set; }
        
        public long ConsultationID { get; set; }
        
        public virtual Consultation Consultation { get; set; }
    }
}