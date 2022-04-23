namespace ServiceMaturityApp.Data
{
    public class ServiceMaturityAudit
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public IEnumerable<ServiceMaturityAttribute> Answers { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}