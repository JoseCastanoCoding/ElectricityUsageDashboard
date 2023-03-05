namespace ElectricityUsageDashboard.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string AccountName { get; set; }
    }
}
