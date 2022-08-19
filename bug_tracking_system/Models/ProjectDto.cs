namespace bug_tracking_system.Models
{
    public class ProjectDto
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public List<Bug> Bugs { get; set; }
    }
}
