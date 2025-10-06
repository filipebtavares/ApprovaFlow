using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public class UserItemViewModel
    {
        public string FullName { get; set; }
        public string Sector { get; set; }
        public string Role { get; set; }
        public string  Email { get; set; }

        public UserItemViewModel(string fullName, string sector, string role, string email)
        {
            FullName = fullName;
            Sector = sector;
            Role = role;
            Email = email;
        }

        public static UserItemViewModel FromEntity(User user)
            => new UserItemViewModel(user.FullName, user.Sector, user.Email, user.Role);
    }
}
