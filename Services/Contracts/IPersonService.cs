using basic_system_poo.Models;

namespace basic_system_poo.Services.Contracts
{
    public interface IPersonService
    {
        string GetDetails(Person person);
    }
}