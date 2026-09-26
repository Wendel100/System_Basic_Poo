namespace basic_system_poo
{
    public class Teacher(string name, string cpf, double salario) : Person(name, cpf)
    {
        double Salario = salario;

        public override void Detaill()
        {
            System.Console.WriteLine($"Name teacher {name}, my money {Salario}, and {cpf}");
        }
    }
}