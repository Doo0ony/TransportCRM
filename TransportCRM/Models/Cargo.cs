using System.ComponentModel.DataAnnotations;

namespace TransportCRM.Models
{
    public class Cargo
    {
        public int CargoId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Origin { get; set; }

        [Required]
        public string Destination { get; set; }

        public double Weight { get; set; }

        public double Volume { get; set; }

        // Navigation property
        public ICollection<Transportation>? Transportations { get; set; }
    }
}
