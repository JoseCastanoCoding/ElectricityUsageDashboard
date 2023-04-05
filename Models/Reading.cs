using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace ElectricityUsageDashboard.Models
{
    public class Reading
    {
        [Key]
        public string UserId { get; set; }
        public int ReadingId { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime ReadingDate { get; set; } 
        public int CurrentReading { get; set; }
        public bool IsBilledReading { get; set; }
        

    }
}
