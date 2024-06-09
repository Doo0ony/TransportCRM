using System.ComponentModel.DataAnnotations;

namespace TransportCRM.Models
{
    public class Transportation
    {
        public int TransportationId { get; set; }

        [Required]
        public DateTime PickupDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        public double Price { get; set; }

        // Foreign key
        public int CargoId { get; set; }

        // Navigation properties
        public Cargo? Cargo { get; set; }
        public ICollection<Truck>? Trucks { get; set; }
    }
}
