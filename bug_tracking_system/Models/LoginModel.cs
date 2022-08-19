using System.ComponentModel.DataAnnotations;

namespace bug_tracking_system.Models
{
    public class LoginModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}