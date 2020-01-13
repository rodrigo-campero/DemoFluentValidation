namespace DemoFluentValidation.Domain.Entities
{
    public class Revenues
    {
        public int RevenuesId { get; set; }
        public decimal Amount { get; set; }
        public EnumBillingTypes BillingTypes { get; set; }
        public int Year { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
