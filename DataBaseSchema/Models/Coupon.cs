namespace DataBaseSchema.Models
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public string CouponName { get; set; }
        public string DiscountType { get; set; }
        public string DiscountValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MaxAmount { get; set; }
        public string MinCartAmount { get; set; }
        public List<Car> AppliesTo { get; set; }


    }
}
