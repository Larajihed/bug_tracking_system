﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bug_tracking_system.Models
{
    public class Bug
    {
        [Key]
        public int BugId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
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
