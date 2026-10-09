
namespace HaiglaDatabaseTask.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; } = "";
        public string PersonalCode { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
