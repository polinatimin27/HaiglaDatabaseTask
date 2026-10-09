
namespace HaiglaDatabaseTask.Models
{
    public class RoomAssignment
    {
        public int RoomAssignmentId { get; set; }
        public int HospitalizationId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
