
namespace HaiglaDatabaseTask.Models
{
    public class Examination
    {
        public int ExaminationId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
    }
}
