using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Infrastructure.Security
{
    public interface IAuthService
    {
        string ComputeHash(string password);
        string GenerateToken(string email, string role);
    }
}
