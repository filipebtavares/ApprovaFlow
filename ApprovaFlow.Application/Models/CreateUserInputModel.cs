using ApprovaFlow.Core.Entity;


namespace ApprovaFlow.Application.Models
{
    public  class CreateUserInputModel
    {
        public string FullName { get; set; }
        public string  Sector { get; set; }
        public string  Role { get; set; }
        public string  Password { get; set; }
        public string  Email { get; set; }
        public string  Cpf { get; set; }

        public User FromEntity()
            => new User(Email, Password, Role, Cpf, FullName, Sector);
    }
}
