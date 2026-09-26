using basic_system_poo.Models;
using basic_system_poo.Services.Contracts;

namespace basic_system_poo.Services
{
    public class AccountService : IAccountService
    {
        public string GetDetails(Account account)
        {
            return $"My name is {account.Name} its number of account {account.Id}, and cpf {account.Cpf}";
        }
    }
}