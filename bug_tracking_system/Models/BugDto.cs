namespace bug_tracking_system.Models
{
    public class BugDto
    {
        public Project Project { get; set; }
        public string? BugDescription { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? ResolutionSummary { get; set; }
        public string? Comments { get; set; }
        public Severities Severity { get; set; }
        public Status BugStatus { get; set; }
        public Priorities Priority { get; set; }
    }
}
