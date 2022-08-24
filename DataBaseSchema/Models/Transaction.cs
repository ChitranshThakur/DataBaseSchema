using DataBaseSchema.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace DataBaseSchema.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public bool PaymentStatus { get; set; }
        public Money Amount { get; set; }



    }
}
