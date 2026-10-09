
namespace HaiglaDatabaseTask.Models
{
    public class Hospitalization
    {
        public int HospitalizationId { get; set; }
        public int PatientId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string Reason { get; set; } = "";
    }
}
