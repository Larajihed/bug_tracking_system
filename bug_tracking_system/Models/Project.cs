using System.ComponentModel.DataAnnotations;

namespace bug_tracking_system.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }

        public List<Bug> Bugs { get; set; }

    }
}