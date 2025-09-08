using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public class UserViewModel
    {
        public string FullName { get; set; }
        public string Sector { get; set; }
        public string Role { get; set; }

        public UserViewModel(string fullName, string sector, string role)
        {
            FullName = fullName;
            Sector = sector;
            Role = role;
        }

        public static UserViewModel FromEntity(User user)
            => new(user.Role, user.Sector, user.FullName);
    }
}
