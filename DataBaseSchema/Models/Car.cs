using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseSchema.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string BaseFarePrice { get; set; }
        public string Model { get; set; }

        [Required]
        public int CategoryID{ get; set; }
        public int SeatingCapacity { get; set; }
        public string EngineType { get; set; }
        public string PlateNumber { get; set; }
        public string FuelType { get; set; }
        public int FuelCapacity { get; set; }
        public int FuelFillup { get; set; }
        public string Hourly_Charge { get; set; }
        public string DailyCharge { get; set; }
        public string WeeklyCharge { get; set; }
        public string MonthlyCharge { get; set; }
        public string ExtraKMCharge { get; set; }
        public string Insurance { get; set; }
        public string GST { get; set; }
        public string DoorstepPickup { get; set; }
        public string RefundableSecurityDeposit { get; set; }
        public string KMSLimits{ get; set; }
        public bool CarStatus {get; set; }
        public string CarFeature { get; set; }
        public string CarViewImage { get; set; }
        public string Details { get; set; }
        public int YearOfManufacturing { get; set; }
        public string Color { get; set; }
        public string Branch { get; set; }
        public string FrontViewImage { get; set; }
        public string RearViewImage { get; set; }
        public string LeftViewImage { get; set; }
        public string RightViewImage { get; set; }
        public string InteriorViewImage { get; set; }
    }
}
