using System.ComponentModel.DataAnnotations;

namespace bug_tracking_system.Models
{
    public class Bug
    {
        [Key]
        public int BugId { get; set; }
        public Project Project { get; set; }
        public string? BugDescription { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public Severity Severity { get; set; }
        public string? ResolutionSummary { get; set; }
        public string? Comments { get; set; }


    }
}
