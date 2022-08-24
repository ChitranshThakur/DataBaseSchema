using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseSchema.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }
        
        [Required]
        public string CustomerName { get; set; }
       
        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string DrivingLicenseNumber { get; set; }
        
        [Required]
        public DateTime LicenseExpireDate { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public bool AadharNumber { get; set; }
        
        [Required]
        public DateTime? DOB { get; set; }

        [ForeignKey("UserID")]
        public virtual List<Booking> Bookings { get; set; }

        [ForeignKey("UserID")]
        public virtual List<Transaction> Transactions { get; set; }

            


    }
}
