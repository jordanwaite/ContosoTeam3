namespace ContosoTeam3.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public Speaker? Speaker { get; set; }
        public string Details { get; set; }
        public string Date { get; set; }

    }
}
