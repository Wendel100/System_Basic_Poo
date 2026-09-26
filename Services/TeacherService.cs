using basic_system_poo.Models;
using basic_system_poo.Services.Contracts;

namespace basic_system_poo.Services
{
    public class TeacherService : ITeacherService
    {
        public string GetDetails(Teacher teacher)
        {
            return $"Name teacher {teacher.Name}, my money {teacher.Salario}, and {teacher.Cpf}";
        }
    }
}