using System.ComponentModel.DataAnnotations;

namespace ElectricityUsageDashboard.Models
{
    public class Reading
    {
        public int ReadingId { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime ReadingDate { get; set; } 
        public int CurrentReading { get; set; }
        public bool IsBilledReading { get; set; }
        

    }
}
