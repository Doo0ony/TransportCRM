using System.ComponentModel.DataAnnotations;

namespace TransportCRM.Models
{
    public class Truck
    {
        public int TruckId { get; set; }

        [Required]
        public string Name { get; set; }

        public double MaxPayload { get; set; }

        // Navigation property
        public ICollection<Transportation>? Transportations { get; set; }
    }
}
