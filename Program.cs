using basic_system_poo.Models;
using basic_system_poo.Services;
using basic_system_poo.Services.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        IAccountService accountService = new AccountService();
        ITeacherService teacherService = new TeacherService();

        Account account = new Account(132424, "Pedro", 34243243);
        account.Saldo = 1000; // Initialize the balance
        System.Console.WriteLine(account.Saldo); 
        System.Console.WriteLine(account.Depositar(500));
        System.Console.WriteLine(account.Sacar(200));
        System.Console.WriteLine(accountService.GetDetails(account));

        Teacher teacher = new("mr.jones", "32445fcgf45e4", 3400);
        System.Console.WriteLine(teacherService.GetDetails(teacher));
    }

}