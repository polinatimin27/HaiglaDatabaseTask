
namespace HaiglaDatabaseTask.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } = "";
        public string EmployeeNumber { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Specialty { get; set; } = "";
        public int DepartmentId { get; set; }
    }
}
