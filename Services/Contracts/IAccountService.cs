using basic_system_poo.Models;

namespace basic_system_poo.Services.Contracts
{
    public interface IAccountService
    {
        string GetDetails(Account account);
    }
}