using System.ComponentModel.DataAnnotations;

namespace ContosoTeam3.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public Speaker? Speaker { get; set; }
        public string? Details { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int NumSeats { get; set; }
        public string? Image { get; set; }

    }
}
