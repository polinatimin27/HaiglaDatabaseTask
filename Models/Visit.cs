
namespace HaiglaDatabaseTask.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime VisitDate { get; set; }
        public TimeSpan VisitTime { get; set; }
        public string Reason { get; set; } = "";
        public string Conclusion { get; set; } = "";
    }
}
