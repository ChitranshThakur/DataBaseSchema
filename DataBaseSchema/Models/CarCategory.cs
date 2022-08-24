using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseSchema.Models
{
    public class CarCategory
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Details { get; set; }
        public string Features { get; set; }

        [ForeignKey("CategoryID")]
        public virtual List<Car> Cars { get; set; }


    }
}
