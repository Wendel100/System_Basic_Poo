using basic_system_poo.Models;
using basic_system_poo.Services.Contracts;

namespace basic_system_poo.Services
{
    public class PersonService : IPersonService
    {
        public string GetDetails(Person person)
        {
            return $"Name: {person.Name}, CPF: {person.Cpf}";
        }
    }
}