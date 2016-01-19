using SpaUserControl.Common.Validation;

namespace SpaUserControl.Domain.Models
{
    public class User
    {
        public User(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public void setPassword(string password, string confirmPassword)
        {
            AssertionConcern.AssertArgumentNotEmpty(password, "Senha vazia");
        }
    }
}
