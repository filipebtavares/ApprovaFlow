using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Core.Entity
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public int Cpf { get; private set; }
        public string FullName { get; private set; }
        public string Sector { get; private set; }
        public List<PurchaseDecision> PurchaseDecisions { get; private set; }
        public List<PurchaseRequest> PurchaseRequests { get; private set; } 
        public bool IsDeleted { get; private set; }

        public User()
        {

        }

        public User(int id, string email, string password, string role, int cpf, string fullName, string sector)
        {
            Id = id;
            Email = email;
            Password = password;
            Role = role;
            Cpf = cpf;
            FullName = fullName;
            Sector = sector;
            IsDeleted = false;
            PurchaseRequests = [];
            PurchaseDecisions = [];
        }

        public void UpdateUser(string fullName, string role, int cpf, string sector, string email)
        {
            FullName = fullName;
            Role = role;
            Cpf = cpf;
            Sector = sector;
            Email = email;
        }


        public void SetAsDeleted()
        {
            IsDeleted = true;
        }

    }
}
