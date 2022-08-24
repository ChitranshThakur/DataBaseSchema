namespace DataBaseSchema.Models.Common
{
    public class Money
    {
        public decimal Amount { get; private set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }
    }
}
