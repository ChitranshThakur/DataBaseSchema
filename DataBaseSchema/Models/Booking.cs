using System.ComponentModel.DataAnnotations;

namespace DataBaseSchema.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public int CustomerID { get; set; }
        
        [Required]
        public int CategoryID { get; set; }
        
        [Required]
        public int CarID { get; set; }
        public bool BookedOn { get; set; }
        public string BookedFrom { get; set; }
        public string BookedTo { get; set; }
        public bool BookedStatus { get; set; }
        public string Remark { get; set; }
        public string TotalCharges { get; set; }

    }
}
