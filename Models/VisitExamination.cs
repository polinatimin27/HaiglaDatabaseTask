
namespace HaiglaDatabaseTask.Models
{
    public class VisitExamination
    {
        public int VisitExaminationId { get; set; }
        public int VisitId { get; set; }
        public int ExaminationId { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string Result { get; set; } = "";
    }
}
