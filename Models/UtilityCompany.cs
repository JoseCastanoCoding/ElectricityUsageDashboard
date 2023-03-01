using System.ComponentModel.DataAnnotations;

namespace ElectricityUsageDashboard.Models
{
    public class UtilityCompany
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set;}
        public string CompanyPhoneNumber { get; set;}
        public string CompanyEmail { get; set;}
        public string CompanyAddress { get; set;}
        public string CompanyCity { get; set;}
        public string CompanyRegion { get; set;}
        public string CompanyPostalCode { get; set;}
        public User AccountNumber { get; }
        public User InvoiceNumber { get; }
        public Reading InvoiceDate { get; }
    }
}
