namespace DemoFluentValidation.Domain.Entities
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string Name { get; set; }
        public int SharePercentage { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
