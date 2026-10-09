
namespace HaiglaDatabaseTask.Models
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string Name { get; set; } = "";
        public string ActiveIngredient { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public string Description { get; set; } = "";
    }
}
