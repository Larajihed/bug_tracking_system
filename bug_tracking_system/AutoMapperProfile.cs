using AutoMapper;
using bug_tracking_system.Models;

namespace bug_tracking_system
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Bug, BugDto>();
        }
    }
}
