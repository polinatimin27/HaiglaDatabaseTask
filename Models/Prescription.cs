
namespace HaiglaDatabaseTask.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public int MedicationId { get; set; }
        public string Dosage { get; set; } = "";
        public int TimesPerDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
